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
    public partial class InputNumber : Form
    {
        private GameController game;
        private String curButton;
        private Form1 f;
        public InputNumber(GameController gameController, Form1 form)
        {
            game = gameController;
            f = form;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        //button to save what the user input
        private void button1_Click(object sender, EventArgs e)
        {
            game.updateNoteDictionary(curButton, notes.Text);
            game.setCoord(curButton, answer.Text);
            this.Hide();
        }

        private void InputNumber_Load(object sender, EventArgs e)
        {

        }

        internal void setNotes(GameController gameController, string button)
        {
            answer.Clear();
            curButton = button;
            notes.Clear();
            notes.Text += gameController.getNotes(curButton);
        }
        //makes sure that the number input textbox is always in focus when this form pops up
        public void resetFocus()
        {
            this.ActiveControl = answer;
        }
    }
}
