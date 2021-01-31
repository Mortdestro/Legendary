using LegendaryEngine;
using LegendaryEngine.CardInterfaces;
using LegendaryHeroes;
using LegendaryTestExpansion;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HeroesExports = LegendaryHeroes.Exports;
using TestExports = LegendaryTestExpansion.Exports;

namespace Legendary
{
    public partial class Form1 : Form
    {
        const int BAD_CARD_LABELS_START_X = 13;
        const int BAD_CARD_LABELS_START_Y = 243;
        const int LABELS_SPACING_X = 100;
        const int LABELS_SPACING_Y = 25;

        GameState GameState { get; set; }
        List<Label> BadCardLabels { get; set; }
        List<Label> StandardHeroLabels { get; set; }

        public Form1()
        {
            InitializeComponent();
            InitializeForm();

            BadCardLabels = new List<Label>();
            StandardHeroLabels = new List<Label>();
        }

        protected void InitializeForm()
        {
            comboBoxPlayers.SelectedItem = "3";
        }

        private void UpdateLabels()
        {
            ClearLabels();

            string cards;

            int offsetY = 0;
            foreach (string type in GameState.BadCardStacks.Keys)
            {
                cards = "";

                BadCardLabels.Add(new Label
                {
                    AutoSize = true,
                    Location = new System.Drawing.Point(BAD_CARD_LABELS_START_X, BAD_CARD_LABELS_START_Y + offsetY),
                    Name = $"labelBadCards{type}",
                    TabIndex = 100 + offsetY / LABELS_SPACING_Y,
                    Text = type
                });

                foreach(ICard card in GameState.BadCardStacks[type])
                {
                    if (card is Wound)
                        cards += "W";
                    if (card is BadCardX)
                        cards += "X";
                }

                BadCardLabels.Add(new Label
                {
                    AutoSize = true,
                    Location = new System.Drawing.Point(BAD_CARD_LABELS_START_X + LABELS_SPACING_X, BAD_CARD_LABELS_START_Y + offsetY),
                    Name = $"labelBadCards{type}Stack",
                    TabIndex = 200 + offsetY / LABELS_SPACING_Y,
                    Text = cards
                });

                offsetY += LABELS_SPACING_Y;
            }

            foreach (Label label in BadCardLabels)
            {
                Controls.Add(label);
            }

            int standardHeroLabelsStartX = BAD_CARD_LABELS_START_X;
            int standardHeroLabelsStartY = BAD_CARD_LABELS_START_Y + LABELS_SPACING_Y * (GameState.BadCardStacks.Keys.Count);

            labelStandardHeroes.Location = new System.Drawing.Point(standardHeroLabelsStartX, standardHeroLabelsStartY);

            offsetY = LABELS_SPACING_Y;
            foreach (string type in GameState.StandardHeroStacks.Keys)
            {
                cards = "";

                StandardHeroLabels.Add(new Label
                {
                    AutoSize = true,
                    Location = new System.Drawing.Point(standardHeroLabelsStartX, standardHeroLabelsStartY + offsetY),
                    Name = $"labelStandardHeroes{type}",
                    TabIndex = 300 + offsetY / LABELS_SPACING_Y,
                    Text = type
                });

                foreach (ICard card in GameState.StandardHeroStacks[type])
                {
                    if (card is ShieldOfficer)
                        cards += "O";
                    if (card is HeroX)
                        cards += "X";
                }

                StandardHeroLabels.Add(new Label
                {
                    AutoSize = true,
                    Location = new System.Drawing.Point(standardHeroLabelsStartX + LABELS_SPACING_X, standardHeroLabelsStartY + offsetY),
                    Name = $"labelStandardHeroes{type}Stack",
                    TabIndex = 400 + offsetY / LABELS_SPACING_Y,
                    Text = cards
                });

                offsetY += LABELS_SPACING_Y;
            }

            foreach (Label label in StandardHeroLabels)
            {
                Controls.Add(label);
            }

            cards = "";
            foreach (ICard card in GameState.BystanderStack)
            {
                if (card is BystanderX)
                    cards += "X";
                else if (card is Bystander)
                    cards += "B";
            }
            labelBystanderStack.Text = cards;
        }

        private void ClearLabels()
        {
            // Bad Cards
            foreach (Label label in BadCardLabels)
            {
                Controls.Remove(label);
            }
            BadCardLabels.Clear();

            // Standard Heroes
            foreach (Label label in StandardHeroLabels)
            {
                Controls.Remove(label);
            }
            StandardHeroLabels.Clear();

            labelBystanderStack.Text = "";
        }

        private void ValidateSetUpButton()
        {
            buttonSetUp.Enabled = checkBoxHeroes.Checked || checkBoxVillains.Checked;
        }

        private void buttonSetUp_Click(object sender, EventArgs e)
        {
            SetUpGame();
            UpdateLabels();
        }

        private void SetUpGame()
        {
            List<Module> modules = new List<Module>();

            if (checkBoxHeroes.Checked)
            {
                modules.Add(HeroesExports.Module);
            }

            if (checkBoxTestExpansion.Checked)
            {
                modules.Add(TestExports.Module);
            }

            GameState = new GameState(int.Parse(comboBoxPlayers.SelectedItem.ToString()));
            GameState.PopulateStacks(modules);
        }

        private void checkBoxHeroes_CheckedChanged(object sender, EventArgs e)
        {
            ValidateSetUpButton();
        }

        private void checkBoxVillains_CheckedChanged(object sender, EventArgs e)
        {
            ValidateSetUpButton();
        }
    }
}
