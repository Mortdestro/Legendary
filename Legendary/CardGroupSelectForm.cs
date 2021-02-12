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
    public partial class CardGroupSelectForm : Form
    {
        private const int COMPONENT_START_X = 16;
        private const int COMPONENT_START_Y = 38;
        private const int COMPONENT_SPACING_Y = 25;
        private const int COMPONENT_TAB_START = 1;

        private readonly int? numGroups;

        public List<(Module module, string groupName)> SelectedGroups { get; set; }


        public enum GroupType { Hero, Villain, Henchman }

        private CardGroupSelectForm()
        {
            InitializeComponent();

            SelectedGroups = new List<(Module, string)>();
        }

        public CardGroupSelectForm(List<Module> modules, GroupType type, int? groups, string title = null, string prompt = null) : this()
        {
            if (title != null)
            {
                Text = title;
            }
            if (prompt != null)
            {
                labelPrompt.Text = prompt;
            }

            numGroups = groups;

            int i = 0;
            foreach (Module module in modules)
            {
                List<string> groupNames;
                switch (type)
                {
                    case GroupType.Villain:
                        groupNames = module.Villains?.Keys.ToList();
                        break;
                    case GroupType.Henchman:
                        groupNames = module.HenchmanVillains?.Keys.ToList();
                        break;
                    case GroupType.Hero:
                    default:
                        groupNames = module.Heroes?.Keys.ToList();
                        break;
                }

                if (groupNames != null)
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

                    foreach (string group in groupNames)
                    {
                        if (groups == 1)
                        {
                            RadioButton radioButton = new RadioButton
                            {
                                AutoSize = true,
                                Location = new Point(COMPONENT_START_X, COMPONENT_START_Y + i * COMPONENT_SPACING_Y),
                                Name = $"radioButtonGroup{module.Name.Replace(" ", "")}{group.Replace(" ", "")}",
                                Size = new Size(85, 17),
                                TabIndex = COMPONENT_TAB_START + i,
                                TabStop = true,
                                Text = group,
                                UseVisualStyleBackColor = true
                            };

                            radioButton.Click += new EventHandler((object obj, EventArgs e) =>
                            {
                                SelectedGroups.Clear();
                                SelectedGroups.Add((module, group));
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
                                Name = $"checkBoxGroup{module.Name.Replace(" ", "")}{group.Replace(" ", "")}",
                                Size = new Size(85, 17),
                                TabIndex = COMPONENT_TAB_START + i,
                                TabStop = true,
                                Text = group,
                                UseVisualStyleBackColor = true
                            };

                            checkBox.Click += new EventHandler((object obj, EventArgs e) =>
                            {
                                if (checkBox.Checked)
                                {
                                    SelectedGroups.Add((module, group));
                                }
                                else
                                {
                                    SelectedGroups.Remove((module, group));
                                }
                                ValidateOkButton();
                            });

                            Controls.Add(checkBox);
                        }
                        i++;
                    }
                }

            }

            buttonOk.Location = new Point(COMPONENT_START_X, COMPONENT_START_Y + i * COMPONENT_SPACING_Y);
            buttonOk.TabIndex = COMPONENT_TAB_START + i;
        }

        private void ValidateOkButton()
        {
            buttonOk.Enabled = !numGroups.HasValue || SelectedGroups.Count == numGroups;
        }
    }
}
