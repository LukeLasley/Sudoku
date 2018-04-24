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
    public partial class Form1 : Form
    {
        private Dictionary<string,Control> buttonsDictionary;
        private GameController gameController;
        private List<Control> notClickable;
        private InputNumber iNum;       

        public Form1()
        {
            InitializeComponent();
            buttonsDictionary = new Dictionary<string, Control>();
            updateButtonDictionary();
            notClickable = new List<Control>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void updateCoord(int y, int x, String value, bool byUser)
        {
            var coordString = "coord" + y + x;
            buttonsDictionary[coordString].Text = value;
            if (byUser)
            {
                buttonsDictionary[coordString].ForeColor = Color.Blue;
            }
        }

        internal void write(string s)
        {
            textBox1.Text += s;
        }

        internal void setInputNumber(InputNumber inputNumber)
        {
            iNum = inputNumber;
        }

        private void updateButtonDictionary()
        {
            foreach (Control control in this.Controls)
            {
                //richTextBox1.Text += control.Name.Substring(0, 4);
                if (control.GetType() == typeof(Button) && control.Name.Substring(0, 5).Equals("coord"))
                {
                    buttonsDictionary.Add(control.Name.ToString(), control);
                }
            }
        }

        private void event_Click(object sender, EventArgs e)
        {
            Control button = (Control)sender;
            if (!notClickable.Contains(button)){
                if (!iNum.IsDisposed)
                {
                    iNum.setNotes(gameController, button.Name.ToString());
                    iNum.Show();
                }
                else
                {
                    iNum = new InputNumber(gameController, this);
                    iNum.setNotes(gameController, button.Name.ToString());
                    iNum.Show();
                }
            }
            
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void setGameController(GameController game)
        {
            gameController = game;
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(Button) && control.Name.Substring(0, 5).Equals("coord"))
                {
                    game.updateNoteDictionary(control.Name.ToString(), "");
                }
            }
        }

        internal void setButtonClickable(int x, int y)
        {
            var coordString = "coord" + y + x;
            Control button = buttonsDictionary[coordString];
            notClickable.Remove(button);
        }

        internal void setButtonNotClickable(int y, int x)
        {
            var coordString = "coord" + y + x;
            Control button = buttonsDictionary[coordString];
            notClickable.Add(button);
        }

        private void solutionChecker_Click(object sender, EventArgs e)
        {
            gameController.checkSolution();
        }
    }
}
