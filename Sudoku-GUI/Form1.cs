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
        List<Control> notClickable;

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
        public void updateCoord(int y, int x, String value)
        {
            var coordString = "coord" + y + x;
            buttonsDictionary[coordString].Text = value;
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
            if(!notClickable.Contains((Control)sender)){
                new InputNumber().Show();
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
                //richTextBox1.Text += control.Name.Substring(0, 4);
                if (control.GetType() == typeof(Button) && control.Name.Substring(0, 5).Equals("coord"))
                {
                    game.updateNoteDictionary(control.Name.ToString());
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
    }
}
