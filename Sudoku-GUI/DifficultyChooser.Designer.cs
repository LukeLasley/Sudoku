namespace Sudoku
{
    partial class DifficultyChooser
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.easyButton = new System.Windows.Forms.Button();
            this.meduimButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(230, 44);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Please select the difficulty of the puzzle you would like to solve.";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // easyButton
            // 
            this.easyButton.Location = new System.Drawing.Point(13, 63);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(75, 23);
            this.easyButton.TabIndex = 1;
            this.easyButton.Text = "Easy";
            this.easyButton.UseVisualStyleBackColor = true;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            // 
            // meduimButton
            // 
            this.meduimButton.Location = new System.Drawing.Point(94, 63);
            this.meduimButton.Name = "meduimButton";
            this.meduimButton.Size = new System.Drawing.Size(75, 23);
            this.meduimButton.TabIndex = 2;
            this.meduimButton.Text = "Meduim";
            this.meduimButton.UseVisualStyleBackColor = true;
            this.meduimButton.Click += new System.EventHandler(this.meduimButton_Click);
            // 
            // hardButton
            // 
            this.hardButton.Location = new System.Drawing.Point(175, 63);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(75, 23);
            this.hardButton.TabIndex = 3;
            this.hardButton.Text = "Hard";
            this.hardButton.UseVisualStyleBackColor = true;
            this.hardButton.Click += new System.EventHandler(this.hardButton_Click);
            // 
            // DifficultyChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 97);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.meduimButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.textBox1);
            this.Name = "DifficultyChooser";
            this.Text = "Select Level";
            this.Load += new System.EventHandler(this.DifficultyChooser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button meduimButton;
        private System.Windows.Forms.Button hardButton;
    }
}