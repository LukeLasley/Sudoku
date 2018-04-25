using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku.Forms
{
    public partial class HintScreen : Form
    {
        private int hintsRemaining;
        public HintScreen(GameController gameController)
        {
            hintsRemaining = gameController.getHints();
            InitializeComponent();
            hintlabel.Text = "You have " + hintsRemaining + " hints remaining.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hintsRemaining > 0)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(hintsRemaining > 0)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
