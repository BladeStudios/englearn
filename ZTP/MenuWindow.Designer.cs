﻿namespace ZTP
{
    partial class MenuWindow
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
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.learningModelLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.modeBox = new System.Windows.Forms.ComboBox();
            this.levelBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.endButton = new System.Windows.Forms.Button();
            this.BazaButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.translationBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.difficultyLabel.Location = new System.Drawing.Point(317, 212);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(344, 32);
            this.difficultyLabel.TabIndex = 0;
            this.difficultyLabel.Text = "POZIOM TRUDNOŚCI:";
            // 
            // learningModelLabel
            // 
            this.learningModelLabel.AutoSize = true;
            this.learningModelLabel.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.learningModelLabel.Location = new System.Drawing.Point(344, 128);
            this.learningModelLabel.Name = "learningModelLabel";
            this.learningModelLabel.Size = new System.Drawing.Size(291, 32);
            this.learningModelLabel.TabIndex = 1;
            this.learningModelLabel.Text = "TRYB PROGRAMU:";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.startButton.Location = new System.Drawing.Point(641, 414);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(218, 52);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // modeBox
            // 
            this.modeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeBox.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.modeBox.FormattingEnabled = true;
            this.modeBox.Items.AddRange(new object[] {
            "TRYB NAUKI",
            "TRYB TESTU"});
            this.modeBox.Location = new System.Drawing.Point(305, 162);
            this.modeBox.Margin = new System.Windows.Forms.Padding(2);
            this.modeBox.Name = "modeBox";
            this.modeBox.Size = new System.Drawing.Size(356, 40);
            this.modeBox.TabIndex = 3;
            // 
            // levelBox
            // 
            this.levelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.levelBox.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.levelBox.FormattingEnabled = true;
            this.levelBox.Items.AddRange(new object[] {
            "ŁATWY",
            "ŚREDNI",
            "TRUDNY",
            "BARDZO TRUDNY",
            "EKSPERT"});
            this.levelBox.Location = new System.Drawing.Point(305, 246);
            this.levelBox.Margin = new System.Windows.Forms.Padding(2);
            this.levelBox.Name = "levelBox";
            this.levelBox.Size = new System.Drawing.Size(356, 40);
            this.levelBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(408, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Englearn ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // endButton
            // 
            this.endButton.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.endButton.Location = new System.Drawing.Point(124, 414);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(218, 52);
            this.endButton.TabIndex = 6;
            this.endButton.Text = "Wyjście";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // BazaButton
            // 
            this.BazaButton.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.BazaButton.Location = new System.Drawing.Point(382, 414);
            this.BazaButton.Name = "BazaButton";
            this.BazaButton.Size = new System.Drawing.Size(218, 52);
            this.BazaButton.TabIndex = 7;
            this.BazaButton.Text = "Baza Danych";
            this.BazaButton.UseVisualStyleBackColor = true;
            this.BazaButton.Click += new System.EventHandler(this.BazaButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(366, 299);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "TŁUMACZENIE:";
            // 
            // translationBox
            // 
            this.translationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.translationBox.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.translationBox.FormattingEnabled = true;
            this.translationBox.Items.AddRange(new object[] {
            "POLSKI-ANGIELSKI",
            "ANGIELSKI-POLSKI"});
            this.translationBox.Location = new System.Drawing.Point(305, 343);
            this.translationBox.Margin = new System.Windows.Forms.Padding(2);
            this.translationBox.Name = "translationBox";
            this.translationBox.Size = new System.Drawing.Size(356, 40);
            this.translationBox.TabIndex = 9;
            // 
            // MenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1005, 576);
            this.Controls.Add(this.translationBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BazaButton);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.levelBox);
            this.Controls.Add(this.modeBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.learningModelLabel);
            this.Controls.Add(this.difficultyLabel);
            this.Name = "MenuWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Englearn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.Label learningModelLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ComboBox modeBox;
        private System.Windows.Forms.ComboBox levelBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Button BazaButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox translationBox;
    }
}

