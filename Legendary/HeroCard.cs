using Legendary.Controls;
using LegendaryEngine.Cards;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legendary
{
    public partial class HeroCard : UserControl
    {
        private Hero Hero;

        private HeroCard()
        {
            InitializeComponent();

            tableLayoutPanel.Controls.Remove(labelRules);
            labelRules = new FormattedLabel
            {
                AutoSize = true,
                //BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(58, 127),
                MaximumSize = new Size(165, int.MaxValue),
                Name = "labelRules",
                Padding = new Padding(0),
                TabIndex = 6
            };
            tableLayoutPanel.Controls.Add(labelRules, 1, 3);

            WireAllControls(this);
        }

        public HeroCard(Hero hero) : this()
        {
            Hero = hero;
            UpdateLabels();
        }

        public void UpdateLabels()
        {
            labelAttack.Text = Hero.PrintedAttackPoints.ToString();
            labelClasses.Text = Hero.PrintedClasses.Aggregate((first, second) => first + "\r\n" + second);
            labelCost.Text = Hero.PrintedCost.ToString();
            labelFlavor.Text = Hero.FlavorText;
            labelRecruit.Text = Hero.PrintedRecruitPoints.ToString();
            labelRules.Text = Hero.RulesText;
            labelSubtitle.Text = Hero.Subtitle;
            labelTeams.Text = Hero.PrintedTeams.Aggregate((first, second) => first + "\r\n" + second);
            labelTitle.Text = Hero.Title;
        }

        private void WireAllControls(Control cont)
        {
            foreach (Control ctl in cont.Controls)
            {
                ctl.Click += ctl_Click;
                if (ctl.HasChildren)
                {
                    WireAllControls(ctl);
                }
            }
        }

        private void ctl_Click(object sender, EventArgs e)
        {
            InvokeOnClick(this, EventArgs.Empty);
        }
    }
}
