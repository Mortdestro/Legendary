using LegendaryEngine;
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
        const int BAD_CARD_LABELS_START_Y = 223;

        GameState GameState { get; set; }
        List<Label> BadCardLabels { get; set; }

        public Form1()
        {
            InitializeComponent();
            InitializeForm();

            BadCardLabels = new List<Label>();
        }

        protected void InitializeForm()
        {
            comboBoxPlayers.SelectedItem = "3";
        }

        private void UpdateLabels()
        {
            ClearLabels();

            string cards = "";

            int offsetY = 0;
            foreach (string type in GameState.BadCardStacks.Keys)
            {
                BadCardLabels.Add(new Label
                {
                    AutoSize = true,
                    Location = new System.Drawing.Point(BAD_CARD_LABELS_START_X, BAD_CARD_LABELS_START_Y + offsetY),
                    Name = $"labelBadCards{type}",
                    TabIndex = 100 + offsetY / 25,
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
                    Location = new System.Drawing.Point(BAD_CARD_LABELS_START_X + 100, BAD_CARD_LABELS_START_Y + offsetY),
                    Name = $"labelBadCards{type}Stack",
                    TabIndex = 200 + offsetY / 25,
                    Text = cards
                });

                offsetY += 25;
            }

            foreach (Label label in BadCardLabels)
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
            foreach (Label x in BadCardLabels)
            {
                Controls.Remove(x);
            }
            BadCardLabels.Clear();

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
