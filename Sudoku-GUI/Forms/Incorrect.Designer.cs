namespace Sudoku.Forms
{
    partial class Incorrect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Incorrect));
            this.hintButton = new System.Windows.Forms.Button();
            this.hintLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.newPuzzleLabel = new System.Windows.Forms.Label();
            this.easyButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hintButton
            // 
            this.hintButton.Location = new System.Drawing.Point(12, 60);
            this.hintButton.Name = "hintButton";
            this.hintButton.Size = new System.Drawing.Size(125, 23);
            this.hintButton.TabIndex = 0;
            this.hintButton.Text = "Yes! Give me a hint!";
            this.hintButton.UseVisualStyleBackColor = true;
            this.hintButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // hintLabel
            // 
            this.hintLabel.AutoSize = true;
            this.hintLabel.Location = new System.Drawing.Point(10, 44);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(68, 13);
            this.hintLabel.TabIndex = 1;
            this.hintLabel.Text = "Need a hint?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sorry that is not the solution to the puzzle.";
            // 
            // newPuzzleLabel
            // 
            this.newPuzzleLabel.AutoSize = true;
            this.newPuzzleLabel.Location = new System.Drawing.Point(13, 99);
            this.newPuzzleLabel.Name = "newPuzzleLabel";
            this.newPuzzleLabel.Size = new System.Drawing.Size(114, 13);
            this.newPuzzleLabel.TabIndex = 3;
            this.newPuzzleLabel.Text = "Give me a new puzzle!";
            // 
            // easyButton
            // 
            this.easyButton.Location = new System.Drawing.Point(16, 116);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(75, 23);
            this.easyButton.TabIndex = 4;
            this.easyButton.Text = "Easy";
            this.easyButton.UseVisualStyleBackColor = true;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            // 
            // mediumButton
            // 
            this.mediumButton.Location = new System.Drawing.Point(97, 115);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(75, 23);
            this.mediumButton.TabIndex = 5;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = true;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            // 
            // hardButton
            // 
            this.hardButton.Location = new System.Drawing.Point(178, 115);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(75, 23);
            this.hardButton.TabIndex = 6;
            this.hardButton.Text = "Hard";
            this.hardButton.UseVisualStyleBackColor = true;
            this.hardButton.Click += new System.EventHandler(this.hardButton_Click);
            // 
            // Incorrect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 162);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.newPuzzleLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hintLabel);
            this.Controls.Add(this.hintButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Incorrect";
            this.Text = "Incorrect";
            this.Load += new System.EventHandler(this.Incorrect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hintButton;
        private System.Windows.Forms.Label hintLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label newPuzzleLabel;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button hardButton;
    }
}