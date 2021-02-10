
namespace Legendary
{
    partial class HeroCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTeams = new System.Windows.Forms.Label();
            this.labelClasses = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.labelRecruit = new System.Windows.Forms.Label();
            this.labelAttack = new System.Windows.Forms.Label();
            this.labelRules = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelFlavor = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTeams
            // 
            this.labelTeams.AutoSize = true;
            this.labelTeams.Location = new System.Drawing.Point(3, 0);
            this.labelTeams.Name = "labelTeams";
            this.labelTeams.Size = new System.Drawing.Size(39, 13);
            this.labelTeams.TabIndex = 0;
            this.labelTeams.Text = "Teams";
            // 
            // labelClasses
            // 
            this.labelClasses.AutoSize = true;
            this.labelClasses.Location = new System.Drawing.Point(3, 26);
            this.labelClasses.Name = "labelClasses";
            this.tableLayoutPanel.SetRowSpan(this.labelClasses, 2);
            this.labelClasses.Size = new System.Drawing.Size(43, 13);
            this.labelClasses.TabIndex = 1;
            this.labelClasses.Text = "Classes";
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(124, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(27, 13);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Title";
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Location = new System.Drawing.Point(116, 26);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(42, 13);
            this.labelSubtitle.TabIndex = 3;
            this.labelSubtitle.Text = "Subtitle";
            // 
            // labelRecruit
            // 
            this.labelRecruit.AutoSize = true;
            this.labelRecruit.Location = new System.Drawing.Point(3, 173);
            this.labelRecruit.Name = "labelRecruit";
            this.labelRecruit.Size = new System.Drawing.Size(41, 13);
            this.labelRecruit.TabIndex = 4;
            this.labelRecruit.Text = "Recruit";
            // 
            // labelAttack
            // 
            this.labelAttack.AutoSize = true;
            this.labelAttack.Location = new System.Drawing.Point(3, 186);
            this.labelAttack.Name = "labelAttack";
            this.labelAttack.Size = new System.Drawing.Size(38, 13);
            this.labelAttack.TabIndex = 5;
            this.labelAttack.Text = "Attack";
            // 
            // labelRules
            // 
            this.labelRules.AutoSize = true;
            this.labelRules.Location = new System.Drawing.Point(53, 173);
            this.labelRules.MaximumSize = new System.Drawing.Size(153, 34);
            this.labelRules.Name = "labelRules";
            this.labelRules.Size = new System.Drawing.Size(54, 13);
            this.labelRules.TabIndex = 6;
            this.labelRules.Text = "Rules text";
            // 
            // labelCost
            // 
            this.labelCost.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(244, 186);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(28, 13);
            this.labelCost.TabIndex = 7;
            this.labelCost.Text = "Cost";
            // 
            // labelFlavor
            // 
            this.labelFlavor.AutoSize = true;
            this.labelFlavor.Location = new System.Drawing.Point(53, 186);
            this.labelFlavor.Name = "labelFlavor";
            this.labelFlavor.Size = new System.Drawing.Size(56, 13);
            this.labelFlavor.TabIndex = 8;
            this.labelFlavor.Text = "Flavor text";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.labelSubtitle, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelTitle, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelClasses, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelTeams, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelCost, 2, 4);
            this.tableLayoutPanel.Controls.Add(this.labelRecruit, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.labelRules, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.labelFlavor, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.labelAttack, 0, 4);
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(275, 200);
            this.tableLayoutPanel.TabIndex = 9;
            // 
            // HeroCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "HeroCard";
            this.Size = new System.Drawing.Size(275, 200);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTeams;
        private System.Windows.Forms.Label labelClasses;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Label labelRecruit;
        private System.Windows.Forms.Label labelAttack;
        private System.Windows.Forms.Label labelRules;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelFlavor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    }
}
