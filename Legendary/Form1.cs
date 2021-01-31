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
        List<Label> PlayerDeckLabels { get; set; }

        public Form1()
        {
            InitializeComponent();
            InitializeForm();

            BadCardLabels = new List<Label>();
            StandardHeroLabels = new List<Label>();
            PlayerDeckLabels = new List<Label>();
        }

        protected void InitializeForm()
        {
            comboBoxPlayers.SelectedItem = "3";
        }

        private void UpdateLabels()
        {
            ClearLabels();

            string cards;

            // Bad Cards //

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

            // Standard Heroes //

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

            // Player Decks //

            int playerDeckLabelsStartX = standardHeroLabelsStartX;
            int playerDeckLabelsStartY = standardHeroLabelsStartY + LABELS_SPACING_Y * (GameState.StandardHeroStacks.Keys.Count + 1);

            labelPlayerDecks.Location = new System.Drawing.Point(playerDeckLabelsStartX, playerDeckLabelsStartY);

            offsetY = LABELS_SPACING_Y;
            foreach (Player player in GameState.Players)
            {
                cards = "";

                PlayerDeckLabels.Add(new Label
                {
                    AutoSize = true,
                    Location = new System.Drawing.Point(playerDeckLabelsStartX, playerDeckLabelsStartY + offsetY),
                    Name = $"labelPlayerDecks{player.Name.Replace(" ", "")}",
                    TabIndex = 500 + offsetY / LABELS_SPACING_Y,
                    Text = player.Name
                });

                foreach (ICard card in player.Deck)
                {
                    if (card is ShieldAgent)
                        cards += "A";
                    if (card is ShieldTrooper)
                        cards += "T";
                }

                PlayerDeckLabels.Add(new Label
                {
                    AutoSize = true,
                    Location = new System.Drawing.Point(playerDeckLabelsStartX + LABELS_SPACING_X, playerDeckLabelsStartY + offsetY),
                    Name = $"label{player.Name.Replace(" ", "")}Deck",
                    TabIndex = 600 + offsetY / LABELS_SPACING_Y,
                    Text = cards
                });

                offsetY += LABELS_SPACING_Y;
            }

            foreach (Label label in PlayerDeckLabels)
            {
                Controls.Add(label);
            }

            // Bystanders //

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

            // Player Decks
            foreach (Label label in PlayerDeckLabels)
            {
                Controls.Remove(label);
            }
            PlayerDeckLabels.Clear();

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
            GameState.PopulateStacks(modules, SelectModule);
        }

        private Module SelectModule(List<Module> modules, string prompt)
        {
            Module module = null;

            using (ModuleSelectForm moduleForm = new ModuleSelectForm(modules, prompt: prompt))
            {
                DialogResult result = moduleForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    module = moduleForm.SelectedModule;
                }
            }

            return module;
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
