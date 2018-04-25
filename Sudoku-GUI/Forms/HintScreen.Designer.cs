namespace Sudoku.Forms
{
    partial class HintScreen
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
            this.hintlabel = new System.Windows.Forms.Label();
            this.mistakeButton = new System.Windows.Forms.Button();
            this.answerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.neitherButton = new System.Windows.Forms.Button();
            this.answerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hintlabel
            // 
            this.hintlabel.AutoSize = true;
            this.hintlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintlabel.Location = new System.Drawing.Point(26, 24);
            this.hintlabel.Name = "hintlabel";
            this.hintlabel.Size = new System.Drawing.Size(206, 20);
            this.hintlabel.TabIndex = 0;
            this.hintlabel.Text = "You have X hints remaining.";
            // 
            // mistakeButton
            // 
            this.mistakeButton.Location = new System.Drawing.Point(12, 111);
            this.mistakeButton.Name = "mistakeButton";
            this.mistakeButton.Size = new System.Drawing.Size(74, 36);
            this.mistakeButton.TabIndex = 1;
            this.mistakeButton.Text = "Check for mistake";
            this.mistakeButton.UseVisualStyleBackColor = true;
            this.mistakeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // answerButton
            // 
            this.answerButton.Location = new System.Drawing.Point(92, 111);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(74, 36);
            this.answerButton.TabIndex = 2;
            this.answerButton.Text = "Give me an answer";
            this.answerButton.UseVisualStyleBackColor = true;
            this.answerButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(27, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Would you like this hint to be for a possible mistake. Or do you want me to give " +
    "you the answer to one of the boxes?";
            // 
            // neitherButton
            // 
            this.neitherButton.Location = new System.Drawing.Point(172, 111);
            this.neitherButton.Name = "neitherButton";
            this.neitherButton.Size = new System.Drawing.Size(74, 36);
            this.neitherButton.TabIndex = 4;
            this.neitherButton.Text = "Neither!";
            this.neitherButton.UseVisualStyleBackColor = true;
            this.neitherButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(18, 175);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(63, 13);
            this.answerLabel.TabIndex = 5;
            this.answerLabel.Text = "Placeholder";
            // 
            // HintScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 254);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.neitherButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.mistakeButton);
            this.Controls.Add(this.hintlabel);
            this.Name = "HintScreen";
            this.Text = "Hint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hintlabel;
        private System.Windows.Forms.Button mistakeButton;
        private System.Windows.Forms.Button answerButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button neitherButton;
        private System.Windows.Forms.Label answerLabel;
    }
}