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
    public partial class VillainCard : CardControl
    {
        private Villain Villain;

        private VillainCard() : base()
        {
            tableLayoutPanel.Controls.Remove(labelRules);
            labelRules = new FormattedLabel
            {
                AutoSize = true,
                Location = new Point(58, 127),
                MaximumSize = new Size(165, int.MaxValue),
                Name = "labelRules",
                Padding = new Padding(0),
                TabIndex = 6
            };
            labelRules.Click += ctl_Click;
            tableLayoutPanel.Controls.Add(labelRules, 1, 3);
        }

        public VillainCard(Villain villain) : this()
        {
            Villain = villain;
            UpdateLabels();
        }

        public override void UpdateLabels()
        {
            labelAttack.Text = "";
            labelClasses.Text = "";
            labelCost.Text = Villain.PrintedAttackPoints.ToString();
            labelFlavor.Text = Villain.FlavorText;
            labelRecruit.Text = Villain.PrintedVictoryPoints.ToString();
            labelRules.Text = Villain.RulesText;
            labelSubtitle.Text = Villain.Subtitle;
            labelTeams.Text = "";
            labelTitle.Text = Villain.Title;
        }
    }
}
