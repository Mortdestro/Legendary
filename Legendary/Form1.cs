using LegendaryEngine;
using LegendaryEngine.Cards;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using HeroesExports = LegendaryHeroes.Exports;
using TestExports = LegendaryTestExpansion.Exports;
using VillainsExports = LegendaryVillains.Exports;

namespace Legendary
{
    public partial class Form1 : Form, ILegendaryInterface
    {
        const int COLUMN1_X = 13;
        const int COLUMN2_X = 424;
        const int BAD_CARD_LABELS_START_Y = 243;
        const int LABELS_SPACING_X = 100;
        const int LABELS_SPACING_Y = 25;
        const float STACK_LABEL_FONT_POINT = 10;

        GameEngine Game { get; set; }
        List<Label> BadCardLabels { get; set; }
        List<Label> StandardHeroLabels { get; set; }
        List<Label> PlayerDeckLabels { get; set; }
        CardControl HeroDeckTopCard { get; set; }
        CardControl VillainDeckTopCard { get; set; }

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

        private void SetUpGame()
        {
            List<Module> modules = new List<Module>();

            if (checkBoxHeroes.Checked)
            {
                modules.Add(HeroesExports.Module);
            }

            if (checkBoxVillains.Checked)
            {
                modules.Add(VillainsExports.Module);
            }

            if (checkBoxTestExpansion.Checked)
            {
                modules.Add(TestExports.Module);
            }

            Game = new GameEngine(int.Parse(comboBoxPlayers.SelectedItem.ToString()), modules, this);
            Game.Start();
        }

        private void UpdateLabels()
        {
            ClearLabels();

            // Scheme //
            labelSchemeCard.Text = Game.Board.Scheme.Title;

            string cards;

            // Bystanders //

            cards = "";
            foreach (Card card in Game.Board.BystanderStack)
            {
                if (card.ID == "BystanderX")
                    cards += "X";
                else if (card.ID == "Bystander")
                    cards += "B";
            }
            labelBystanderStack.Font = new Font(FontFamily.GenericMonospace, STACK_LABEL_FONT_POINT);
            labelBystanderStack.Text = cards;

            // Bad Cards //

            int offsetY = 0;
            foreach (string type in Game.Board.BadCardStacks.Keys)
            {
                cards = "";

                BadCardLabels.Add(new Label
                {
                    AutoSize = true,
                    Location = new Point(COLUMN1_X, BAD_CARD_LABELS_START_Y + offsetY),
                    Name = $"labelBadCards{type}",
                    TabIndex = 100 + offsetY / LABELS_SPACING_Y,
                    Text = type
                });

                foreach (Card card in Game.Board.BadCardStacks[type])
                {
                    if (card.ID == "Wound")
                        cards += "W";
                    else if (card.ID == "Bindings")
                        cards += "B";
                    else if (card.ID == "BadCardX")
                        cards += "X";
                }

                BadCardLabels.Add(new Label
                {
                    AutoSize = true,
                    Font = new Font(FontFamily.GenericMonospace, STACK_LABEL_FONT_POINT),
                    Location = new Point(COLUMN1_X + LABELS_SPACING_X, BAD_CARD_LABELS_START_Y + offsetY),
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

            int standardHeroLabelsStartX = COLUMN1_X;
            int standardHeroLabelsStartY = BAD_CARD_LABELS_START_Y + LABELS_SPACING_Y * (Game.Board.BadCardStacks.Keys.Count);

            labelStandardHeroes.Location = new Point(standardHeroLabelsStartX, standardHeroLabelsStartY);

            offsetY = LABELS_SPACING_Y;
            foreach (string type in Game.Board.StandardHeroStacks.Keys)
            {
                cards = "";

                StandardHeroLabels.Add(new Label
                {
                    AutoSize = true,
                    Location = new Point(standardHeroLabelsStartX, standardHeroLabelsStartY + offsetY),
                    Name = $"labelStandardHeroes{type}",
                    TabIndex = 300 + offsetY / LABELS_SPACING_Y,
                    Text = type
                });

                foreach (Card card in Game.Board.StandardHeroStacks[type])
                {
                    if (card.ID == "ShieldOfficer")
                        cards += "O";
                    else if (card.ID == "MadameHydra")
                        cards += "M";
                    else if (card.ID == "NewRecruits")
                        cards += "R";
                    else if (card.ID == "HeroX")
                        cards += "X";
                }

                StandardHeroLabels.Add(new Label
                {
                    AutoSize = true,
                    Font = new Font(FontFamily.GenericMonospace, STACK_LABEL_FONT_POINT),
                    Location = new Point(standardHeroLabelsStartX + LABELS_SPACING_X, standardHeroLabelsStartY + offsetY),
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

            int playerDeckLabelsStartX = COLUMN1_X;
            int playerDeckLabelsStartY = standardHeroLabelsStartY + LABELS_SPACING_Y * (Game.Board.StandardHeroStacks.Keys.Count + 1);

            labelPlayerDecks.Location = new Point(playerDeckLabelsStartX, playerDeckLabelsStartY);

            offsetY = LABELS_SPACING_Y;
            foreach (Player player in Game.Players)
            {
                cards = "";

                PlayerDeckLabels.Add(new Label
                {
                    AutoSize = true,
                    Location = new Point(playerDeckLabelsStartX, playerDeckLabelsStartY + offsetY),
                    Name = $"labelPlayerDecks{player.Name.Replace(" ", "")}",
                    TabIndex = 500 + offsetY / LABELS_SPACING_Y,
                    Text = player.Name
                });

                foreach (Card card in player.Deck)
                {
                    if (card.ID == "ShieldAgent")
                        cards += "A";
                    else if (card.ID == "ShieldTrooper")
                        cards += "T";
                    else if (card.ID == "HydraOperative")
                        cards += "O";
                    else if (card.ID == "HydraSoldier")
                        cards += "S";
                }

                PlayerDeckLabels.Add(new Label
                {
                    AutoSize = true,
                    Font = new Font(FontFamily.GenericMonospace, STACK_LABEL_FONT_POINT),
                    Location = new Point(playerDeckLabelsStartX + LABELS_SPACING_X, playerDeckLabelsStartY + offsetY),
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

            // Hero Deck //

            int heroDeckLabelsStartX = COLUMN1_X;
            int heroDeckLabelsStartY = playerDeckLabelsStartY + LABELS_SPACING_Y * (Game.Players.Count + 2);

            labelHeroDeck.Location = new Point(heroDeckLabelsStartX, heroDeckLabelsStartY);

            Card heroCard = Game.Board.HeroDeck[0];

            Controls.Remove(HeroDeckTopCard);
            if (heroCard is Hero hero)
            {
                HeroDeckTopCard = new HeroCard(hero)
                {
                    AutoSize = true,
                    Location = new Point(heroDeckLabelsStartX, heroDeckLabelsStartY + LABELS_SPACING_Y),
                    Name = $"heroDeckTopCard",
                    TabIndex = 700 + offsetY / LABELS_SPACING_Y
                };
            }

            HeroDeckTopCard.Click += new EventHandler(HeroDeckTopCard_Click);

            Controls.Add(HeroDeckTopCard);

            // Villain Deck //

            int villainDeckLabelsStartX = COLUMN2_X;
            int villainDeckLabelsStartY = heroDeckLabelsStartY;

            labelVillainDeck.Location = new Point(villainDeckLabelsStartX, villainDeckLabelsStartY);

            Card villainCard = Game.Board.VillainDeck[0];

            Controls.Remove(VillainDeckTopCard);
            if (villainCard is Villain villain)
            {
                VillainDeckTopCard = new VillainCard(villain)
                {
                    AutoSize = true,
                    Location = new Point(villainDeckLabelsStartX, villainDeckLabelsStartY + LABELS_SPACING_Y),
                    Name = $"villainDeckTopCard",
                    TabIndex = 700 + offsetY / LABELS_SPACING_Y
                };
            }
            else if (villainCard is Bystander bystander)
            {
                VillainDeckTopCard = new BystanderCard(bystander)
                {
                    AutoSize = true,
                    Location = new Point(villainDeckLabelsStartX, villainDeckLabelsStartY + LABELS_SPACING_Y),
                    Name = $"villainDeckTopCard",
                    TabIndex = 700 + offsetY / LABELS_SPACING_Y
                };
            }
            else if (villainCard is Twist twist)
            {
                VillainDeckTopCard = new TwistCard(twist)
                {
                    AutoSize = true,
                    Location = new Point(villainDeckLabelsStartX, villainDeckLabelsStartY + LABELS_SPACING_Y),
                    Name = $"villainDeckTopCard",
                    TabIndex = 700 + offsetY / LABELS_SPACING_Y
                };
            }

            VillainDeckTopCard.Click += new EventHandler(VillainDeckTopCard_Click);

            Controls.Add(VillainDeckTopCard);
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

            // Hero Deck
            Controls.Remove(HeroDeckTopCard);

            // Villain Deck
            Controls.Remove(VillainDeckTopCard);

            labelSchemeCard.Text = "";
            labelBystanderStack.Text = "";
        }

        public Module SelectModule(List<Module> modules, string prompt = "Select an expansion:")
        {
            Module module = null;

            using (ModuleSelectForm moduleForm = new ModuleSelectForm(modules, "Marvel Legendary - Expansions", prompt))
            {
                DialogResult result = moduleForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    module = moduleForm.SelectedModule;
                }
            }

            return module;
        }

        public Scheme SelectScheme(List<Module> modules, string prompt = "Select a Scheme:")
        {
            Scheme scheme = null;

            using (SchemeSelectForm schemeForm = new SchemeSelectForm(modules, "Marvel Legendary - Expansions", prompt))
            {
                DialogResult result = schemeForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    scheme = schemeForm.SelectedScheme;
                }
            }

            return scheme;
        }

        public List<(Module module, string villain)> SelectVillains(List<Module> modules, int? numVillains, string prompt = "Select Villains:")
        {
            List<(Module module, string villain)> villains = null;

            using (CardGroupSelectForm villainForm = new CardGroupSelectForm(modules, CardGroupSelectForm.GroupType.Villain, numVillains, "Villain Select", prompt))
            {
                DialogResult result = villainForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    villains = villainForm.SelectedGroups;
                }
            }

            return villains;
        }

        public List<(Module module, string henchman)> SelectHenchmanVillains(List<Module> modules, int? numVillains, string prompt = "Select Henchman Villains:")
        {
            List<(Module module, string henchman)> villains = null;

            using (CardGroupSelectForm villainForm = new CardGroupSelectForm(modules, CardGroupSelectForm.GroupType.Henchman, numVillains, "Henchman Villain Select", prompt))
            {
                DialogResult result = villainForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    villains = villainForm.SelectedGroups;
                }
            }

            return villains;
        }

        public List<(Module module, string hero)> SelectHeroes(List<Module> modules, int? numHeroes, string prompt = "Select Heroes:")
        {
            List<(Module module, string hero)> heroes = null;

            using (CardGroupSelectForm heroForm = new CardGroupSelectForm(modules, CardGroupSelectForm.GroupType.Hero, numHeroes, "Hero Select", prompt))
            {
                DialogResult result = heroForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    heroes = heroForm.SelectedGroups;
                }
            }

            return heroes;
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

        private void HeroDeckTopCard_Click(object sender, EventArgs e)
        {
            Card card = Game.Board.HeroDeck.Draw();
            Game.Board.HeroDeck.Add(card);
            UpdateLabels();
        }

        private void VillainDeckTopCard_Click(object sender, EventArgs e)
        {
            Card card = Game.Board.VillainDeck.Draw();
            Game.Board.HeroDeck.Add(card);
            UpdateLabels();
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
