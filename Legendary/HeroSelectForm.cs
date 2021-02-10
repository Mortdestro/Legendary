using LegendaryEngine;
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
    public partial class HeroSelectForm : Form
    {
        private const int COMPONENT_START_X = 16;
        private const int COMPONENT_START_Y = 38;
        private const int COMPONENT_SPACING_Y = 25;
        private const int COMPONENT_TAB_START = 1;

        private readonly int? numHeroes;

        public List<(Module module, string hero)> SelectedHeroes { get; set; }

        private HeroSelectForm()
        {
            InitializeComponent();

            SelectedHeroes = new List<(Module module, string hero)>();
        }

        public HeroSelectForm(List<Module> modules, int? numHeroes, string title = null, string prompt = null) : this()
        {
            if (title != null)
            {
                Text = title;
            }
            if (prompt != null)
            {
                labelPrompt.Text = prompt;
            }

            this.numHeroes = numHeroes;

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
                    TabStop = true,
                    Text = module.Name
                };

                Controls.Add(label);

                i++;

                foreach (string hero in module.Heroes.Keys)
                {
                    if (numHeroes == 1)
                    {
                        RadioButton radioButton = new RadioButton
                        {
                            AutoSize = true,
                            Location = new Point(COMPONENT_START_X, COMPONENT_START_Y + i * COMPONENT_SPACING_Y),
                            Name = $"radioButtonHero{module.Name.Replace(" ", "")}{hero.Replace(" ", "")}",
                            Size = new Size(85, 17),
                            TabIndex = COMPONENT_TAB_START + i,
                            TabStop = true,
                            Text = hero,
                            UseVisualStyleBackColor = true
                        };

                        radioButton.Click += new EventHandler((object obj, EventArgs e) =>
                        {
                            SelectedHeroes.Clear();
                            SelectedHeroes.Add((module, hero));
                            ValidateOkButton();
                        });

                        Controls.Add(radioButton);
                    }
                    else
                    {
                        CheckBox checkBox = new CheckBox
                        {
                            AutoSize = true,
                            Location = new Point(COMPONENT_START_X, COMPONENT_START_Y + i * COMPONENT_SPACING_Y),
                            Name = $"checkBoxHero{module.Name.Replace(" ", "")}{hero.Replace(" ", "")}",
                            Size = new Size(85, 17),
                            TabIndex = COMPONENT_TAB_START + i,
                            TabStop = true,
                            Text = hero,
                            UseVisualStyleBackColor = true
                        };

                        checkBox.Click += new EventHandler((object obj, EventArgs e) =>
                        {
                            if (checkBox.Checked) {
                                SelectedHeroes.Add((module, hero));
                            }
                            else
                            {
                                SelectedHeroes.Remove((module, hero));
                            }
                            ValidateOkButton();
                        });

                        Controls.Add(checkBox);
                    }

                    i++;
                }
            }

            buttonOk.Location = new Point(COMPONENT_START_X, COMPONENT_START_Y + i * COMPONENT_SPACING_Y);
            buttonOk.TabIndex = COMPONENT_TAB_START + i;
        }

        private void ValidateOkButton()
        {
            buttonOk.Enabled = !numHeroes.HasValue || SelectedHeroes.Count == numHeroes;
        }
    }
}
