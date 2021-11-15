
namespace _20109982_van_Wyk_POE
{
    partial class GameForm
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
            this.playerStatsLabel = new System.Windows.Forms.Label();
            this.playerStatsDisplayed = new System.Windows.Forms.Label();
            this.leftButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.enemyTargeterComboBox = new System.Windows.Forms.ComboBox();
            this.attackButton = new System.Windows.Forms.Button();
            this.gameHistoryTextBox = new System.Windows.Forms.RichTextBox();
            this.mapRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // playerStatsLabel
            // 
            this.playerStatsLabel.AutoSize = true;
            this.playerStatsLabel.Location = new System.Drawing.Point(13, 13);
            this.playerStatsLabel.Name = "playerStatsLabel";
            this.playerStatsLabel.Size = new System.Drawing.Size(63, 13);
            this.playerStatsLabel.TabIndex = 0;
            this.playerStatsLabel.Text = "Player Stats";
            this.playerStatsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // playerStatsDisplayed
            // 
            this.playerStatsDisplayed.AutoSize = true;
            this.playerStatsDisplayed.Location = new System.Drawing.Point(12, 26);
            this.playerStatsDisplayed.Name = "playerStatsDisplayed";
            this.playerStatsDisplayed.Size = new System.Drawing.Size(63, 13);
            this.playerStatsDisplayed.TabIndex = 1;
            this.playerStatsDisplayed.Text = "Player Stats";
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(12, 415);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(75, 23);
            this.leftButton.TabIndex = 2;
            this.leftButton.Text = "Left";
            this.leftButton.UseVisualStyleBackColor = true;
            // 
            // downButton
            // 
            this.downButton.Location = new System.Drawing.Point(93, 415);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(75, 23);
            this.downButton.TabIndex = 3;
            this.downButton.Text = "Down";
            this.downButton.UseVisualStyleBackColor = true;
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(174, 415);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(75, 23);
            this.rightButton.TabIndex = 4;
            this.rightButton.Text = "Right";
            this.rightButton.UseVisualStyleBackColor = true;
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(93, 386);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(75, 23);
            this.upButton.TabIndex = 5;
            this.upButton.Text = "Up";
            this.upButton.UseVisualStyleBackColor = true;
            // 
            // enemyTargeterComboBox
            // 
            this.enemyTargeterComboBox.FormattingEnabled = true;
            this.enemyTargeterComboBox.Location = new System.Drawing.Point(667, 5);
            this.enemyTargeterComboBox.Name = "enemyTargeterComboBox";
            this.enemyTargeterComboBox.Size = new System.Drawing.Size(121, 21);
            this.enemyTargeterComboBox.TabIndex = 6;
            // 
            // attackButton
            // 
            this.attackButton.Location = new System.Drawing.Point(586, 3);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(75, 23);
            this.attackButton.TabIndex = 7;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = true;
            // 
            // gameHistoryTextBox
            // 
            this.gameHistoryTextBox.Location = new System.Drawing.Point(667, 288);
            this.gameHistoryTextBox.Name = "gameHistoryTextBox";
            this.gameHistoryTextBox.Size = new System.Drawing.Size(121, 150);
            this.gameHistoryTextBox.TabIndex = 8;
            this.gameHistoryTextBox.Text = "";
            // 
            // mapRichTextBox
            // 
            this.mapRichTextBox.Location = new System.Drawing.Point(15, 43);
            this.mapRichTextBox.Name = "mapRichTextBox";
            this.mapRichTextBox.Size = new System.Drawing.Size(234, 337);
            this.mapRichTextBox.TabIndex = 9;
            this.mapRichTextBox.Text = "";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mapRichTextBox);
            this.Controls.Add(this.gameHistoryTextBox);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.enemyTargeterComboBox);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.playerStatsDisplayed);
            this.Controls.Add(this.playerStatsLabel);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerStatsLabel;
        private System.Windows.Forms.Label playerStatsDisplayed;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.ComboBox enemyTargeterComboBox;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.RichTextBox gameHistoryTextBox;
        private System.Windows.Forms.RichTextBox mapRichTextBox;
    }
}