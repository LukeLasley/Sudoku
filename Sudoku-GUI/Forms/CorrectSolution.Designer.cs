namespace Sudoku.Forms
{
    partial class CorrectSolution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CorrectSolution));
            this.correctLabel = new System.Windows.Forms.Label();
            this.playAgainLabel = new System.Windows.Forms.Label();
            this.easyButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // correctLabel
            // 
            this.correctLabel.AutoSize = true;
            this.correctLabel.Location = new System.Drawing.Point(13, 13);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(247, 13);
            this.correctLabel.TabIndex = 0;
            this.correctLabel.Text = "That is the correct solution to the board! Good Job!";
            // 
            // playAgainLabel
            // 
            this.playAgainLabel.Location = new System.Drawing.Point(12, 96);
            this.playAgainLabel.Name = "playAgainLabel";
            this.playAgainLabel.Size = new System.Drawing.Size(248, 35);
            this.playAgainLabel.TabIndex = 1;
            this.playAgainLabel.Text = "If you would like to solve a new board please select from the difficulties below." +
    "";
            // 
            // easyButton
            // 
            this.easyButton.Location = new System.Drawing.Point(16, 135);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(75, 23);
            this.easyButton.TabIndex = 2;
            this.easyButton.Text = "Easy";
            this.easyButton.UseVisualStyleBackColor = true;
            // 
            // mediumButton
            // 
            this.mediumButton.Location = new System.Drawing.Point(97, 134);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(75, 23);
            this.mediumButton.TabIndex = 3;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = true;
            // 
            // hardButton
            // 
            this.hardButton.Location = new System.Drawing.Point(178, 134);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(75, 23);
            this.hardButton.TabIndex = 4;
            this.hardButton.Text = "Hard";
            this.hardButton.UseVisualStyleBackColor = true;
            // 
            // CorrectSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(267, 168);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.playAgainLabel);
            this.Controls.Add(this.correctLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CorrectSolution";
            this.Text = "Correct!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.Label playAgainLabel;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button hardButton;
    }
}