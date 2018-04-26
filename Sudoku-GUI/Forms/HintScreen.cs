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
        private GameController game;
        private Form1 gui;

        public HintScreen(GameController gameController, Form1 f)
        {
            game = gameController;
            gui = f;
            hintsRemaining = game.getHints();
            InitializeComponent();
            hintlabel.Text = "You have " + hintsRemaining + " hints remaining.";
            if(hintsRemaining < 1)
            {
                mistakeButton.Enabled = false;
                answerButton.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tuple<Point, int> hint = game.giveHint(true);
            if(hint.Item2 != -1)
            {
                gui.updateWithHint(hint, Color.Red);
                game.decrementHintsRemaining();
            }
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tuple<Point, int> hint = game.giveHint(false);
            if (hint.Item2 != -1)
            {
                gui.updateWithHint(hint, Color.Green);
                game.decrementHintsRemaining();
            }
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
