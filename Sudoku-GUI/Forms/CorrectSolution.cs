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
    public partial class CorrectSolution : Form
    {
        GameController gameController;
        public CorrectSolution(GameController game)
        {
            gameController = game;
            InitializeComponent();
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            gameController.rebuild();
            gameController.createEasyGame();
            this.Dispose();
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            gameController.rebuild();
            gameController.createMediumGame();
            this.Dispose();
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            gameController.rebuild();
            gameController.createHardGame();
            this.Dispose();
        }
    }
}
