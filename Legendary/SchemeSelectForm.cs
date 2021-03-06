﻿using LegendaryEngine;
using LegendaryEngine.Cards;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legendary
{
    public partial class SchemeSelectForm : Form
    {
        private const int COMPONENT_START_X = 16;
        private const int COMPONENT_START_Y = 38;
        private const int COMPONENT_SPACING_Y = 25;
        private const int COMPONENT_TAB_START = 1;

        public Scheme SelectedScheme { get; set; }

        private SchemeSelectForm()
        {
            InitializeComponent();
        }

        public SchemeSelectForm(List<Module> modules, string title = null, string prompt = null) : this()
        {
            if (title != null)
            {
                Text = title;
            }
            if (prompt != null)
            {
                labelPrompt.Text = prompt;
            }

            int i = 0;
            foreach (Module module in modules)
            {
                Label label = new Label
                {
                    AutoSize = true,
                    Font = new Font(FontFamily.GenericSansSerif, (float)8.25, FontStyle.Underline),
                    Location = new Point(COMPONENT_START_X, COMPONENT_START_Y + i * COMPONENT_SPACING_Y),
                    Name = $"labelModule{module.Name.Replace(" ", "")}",
                    Size = new Size(85, 17),
                    TabIndex = COMPONENT_TAB_START + i,
                    Text = module.Name
                };

                Controls.Add(label);

                i++;
                foreach (Scheme scheme in module.Schemes)
                {
                    RadioButton radioButton = new RadioButton
                    {
                        AutoSize = true,
                        Location = new Point(COMPONENT_START_X, COMPONENT_START_Y + i * COMPONENT_SPACING_Y),
                        Name = $"radioButtonScheme{module.Name.Replace(" ", "")}{scheme.ID}",
                        Size = new Size(85, 17),
                        TabIndex = COMPONENT_TAB_START + i,
                        TabStop = true,
                        Text = scheme.Title,
                        UseVisualStyleBackColor = true
                    };

                    radioButton.Click += new EventHandler((object obj, EventArgs e) =>
                    {
                        buttonOk.Enabled = true;
                        SelectedScheme = scheme;
                    });

                    Controls.Add(radioButton);

                    i++;
                }
            }

            buttonOk.Location = new Point(COMPONENT_START_X, COMPONENT_START_Y + i * COMPONENT_SPACING_Y);
            buttonOk.TabIndex = COMPONENT_TAB_START + i;
        }
    }
}
