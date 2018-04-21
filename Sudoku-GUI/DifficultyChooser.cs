using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class DifficultyChooser : Form
    {
        private GameController game;

        public DifficultyChooser(GameController gameControl)
        {
            game = gameControl;
            InitializeComponent();
        }

        private void DifficultyChooser_Load(object sender, EventArgs e)
        {

        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            game.createEasyGame();
            this.Hide();
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            game.createHardGame();
            this.Hide();
        }

        private void meduimButton_Click(object sender, EventArgs e)
        {
            game.createMediumGame();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
