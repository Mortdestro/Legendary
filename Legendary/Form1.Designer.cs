
namespace Legendary
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSetUp = new System.Windows.Forms.Button();
            this.labelPlayers = new System.Windows.Forms.Label();
            this.comboBoxPlayers = new System.Windows.Forms.ComboBox();
            this.labelBaseGame = new System.Windows.Forms.Label();
            this.checkBoxHeroes = new System.Windows.Forms.CheckBox();
            this.checkBoxVillains = new System.Windows.Forms.CheckBox();
            this.labelExpansions = new System.Windows.Forms.Label();
            this.checkBoxTestExpansion = new System.Windows.Forms.CheckBox();
            this.labelBadCards = new System.Windows.Forms.Label();
            this.labelBystanders = new System.Windows.Forms.Label();
            this.labelBystanderStack = new System.Windows.Forms.Label();
            this.labelStandardHeroes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSetUp
            // 
            this.buttonSetUp.Location = new System.Drawing.Point(16, 124);
            this.buttonSetUp.Name = "buttonSetUp";
            this.buttonSetUp.Size = new System.Drawing.Size(75, 23);
            this.buttonSetUp.TabIndex = 0;
            this.buttonSetUp.Text = "Set Up";
            this.buttonSetUp.UseVisualStyleBackColor = true;
            this.buttonSetUp.Click += new System.EventHandler(this.buttonSetUp_Click);
            // 
            // labelPlayers
            // 
            this.labelPlayers.AutoSize = true;
            this.labelPlayers.Location = new System.Drawing.Point(13, 13);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(41, 13);
            this.labelPlayers.TabIndex = 0;
            this.labelPlayers.Text = "Players";
            // 
            // comboBoxPlayers
            // 
            this.comboBoxPlayers.FormattingEnabled = true;
            this.comboBoxPlayers.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxPlayers.Location = new System.Drawing.Point(80, 10);
            this.comboBoxPlayers.Name = "comboBoxPlayers";
            this.comboBoxPlayers.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPlayers.TabIndex = 1;
            // 
            // labelBaseGame
            // 
            this.labelBaseGame.AutoSize = true;
            this.labelBaseGame.Location = new System.Drawing.Point(13, 48);
            this.labelBaseGame.Name = "labelBaseGame";
            this.labelBaseGame.Size = new System.Drawing.Size(60, 13);
            this.labelBaseGame.TabIndex = 2;
            this.labelBaseGame.Text = "Base game";
            // 
            // checkBoxHeroes
            // 
            this.checkBoxHeroes.AutoSize = true;
            this.checkBoxHeroes.Checked = true;
            this.checkBoxHeroes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHeroes.Location = new System.Drawing.Point(80, 47);
            this.checkBoxHeroes.Name = "checkBoxHeroes";
            this.checkBoxHeroes.Size = new System.Drawing.Size(60, 17);
            this.checkBoxHeroes.TabIndex = 3;
            this.checkBoxHeroes.Text = "Heroes";
            this.checkBoxHeroes.UseVisualStyleBackColor = true;
            this.checkBoxHeroes.CheckedChanged += new System.EventHandler(this.checkBoxHeroes_CheckedChanged);
            // 
            // checkBoxVillains
            // 
            this.checkBoxVillains.AutoSize = true;
            this.checkBoxVillains.Enabled = false;
            this.checkBoxVillains.Location = new System.Drawing.Point(80, 70);
            this.checkBoxVillains.Name = "checkBoxVillains";
            this.checkBoxVillains.Size = new System.Drawing.Size(58, 17);
            this.checkBoxVillains.TabIndex = 4;
            this.checkBoxVillains.Text = "Villains";
            this.checkBoxVillains.UseVisualStyleBackColor = true;
            this.checkBoxVillains.CheckedChanged += new System.EventHandler(this.checkBoxVillains_CheckedChanged);
            // 
            // labelExpansions
            // 
            this.labelExpansions.AutoSize = true;
            this.labelExpansions.Location = new System.Drawing.Point(13, 102);
            this.labelExpansions.Name = "labelExpansions";
            this.labelExpansions.Size = new System.Drawing.Size(61, 13);
            this.labelExpansions.TabIndex = 5;
            this.labelExpansions.Text = "Expansions";
            // 
            // checkBoxTestExpansion
            // 
            this.checkBoxTestExpansion.AutoSize = true;
            this.checkBoxTestExpansion.Location = new System.Drawing.Point(80, 101);
            this.checkBoxTestExpansion.Name = "checkBoxTestExpansion";
            this.checkBoxTestExpansion.Size = new System.Drawing.Size(99, 17);
            this.checkBoxTestExpansion.TabIndex = 6;
            this.checkBoxTestExpansion.Text = "Test Expansion";
            this.checkBoxTestExpansion.UseVisualStyleBackColor = true;
            // 
            // labelBadCards
            // 
            this.labelBadCards.AutoSize = true;
            this.labelBadCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBadCards.Location = new System.Drawing.Point(13, 218);
            this.labelBadCards.Name = "labelBadCards";
            this.labelBadCards.Size = new System.Drawing.Size(56, 13);
            this.labelBadCards.TabIndex = 7;
            this.labelBadCards.Text = "Bad Cards";
            // 
            // labelBystanders
            // 
            this.labelBystanders.AutoSize = true;
            this.labelBystanders.Location = new System.Drawing.Point(13, 193);
            this.labelBystanders.Name = "labelBystanders";
            this.labelBystanders.Size = new System.Drawing.Size(59, 13);
            this.labelBystanders.TabIndex = 8;
            this.labelBystanders.Text = "Bystanders";
            // 
            // labelBystanderStack
            // 
            this.labelBystanderStack.AutoSize = true;
            this.labelBystanderStack.Location = new System.Drawing.Point(113, 193);
            this.labelBystanderStack.Name = "labelBystanderStack";
            this.labelBystanderStack.Size = new System.Drawing.Size(0, 13);
            this.labelBystanderStack.TabIndex = 9;
            // 
            // labelStandardHeroes
            // 
            this.labelStandardHeroes.AutoSize = true;
            this.labelStandardHeroes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStandardHeroes.Location = new System.Drawing.Point(12, 243);
            this.labelStandardHeroes.Name = "labelStandardHeroes";
            this.labelStandardHeroes.Size = new System.Drawing.Size(87, 13);
            this.labelStandardHeroes.TabIndex = 399;
            this.labelStandardHeroes.Text = "Standard Heroes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelStandardHeroes);
            this.Controls.Add(this.labelBystanderStack);
            this.Controls.Add(this.labelBystanders);
            this.Controls.Add(this.labelBadCards);
            this.Controls.Add(this.checkBoxTestExpansion);
            this.Controls.Add(this.labelExpansions);
            this.Controls.Add(this.checkBoxVillains);
            this.Controls.Add(this.checkBoxHeroes);
            this.Controls.Add(this.labelBaseGame);
            this.Controls.Add(this.comboBoxPlayers);
            this.Controls.Add(this.labelPlayers);
            this.Controls.Add(this.buttonSetUp);
            this.Name = "Form1";
            this.Text = "Legendary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSetUp;
        private System.Windows.Forms.Label labelPlayers;
        private System.Windows.Forms.ComboBox comboBoxPlayers;
        private System.Windows.Forms.Label labelBaseGame;
        private System.Windows.Forms.CheckBox checkBoxHeroes;
        private System.Windows.Forms.CheckBox checkBoxVillains;
        private System.Windows.Forms.Label labelExpansions;
        private System.Windows.Forms.CheckBox checkBoxTestExpansion;
        private System.Windows.Forms.Label labelBadCards;
        private System.Windows.Forms.Label labelBystanders;
        private System.Windows.Forms.Label labelBystanderStack;
        private System.Windows.Forms.Label labelStandardHeroes;
    }
}

