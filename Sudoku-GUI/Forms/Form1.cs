using Sudoku.Forms;
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

        internal void updateWithHint(Tuple<Point, int> hint, Color color)
        {
            Point location = hint.Item1;
            int answer = hint.Item2;
            var coordString = "coord" + location.Y + location.X;
            buttonsDictionary[coordString].Text = answer.ToString();
            buttonsDictionary[coordString].ForeColor = color;
            
        }

        //updates the box in the gui. If done by user set the text to blue so they know which numbers they can edit
        public void updateCoord(int y, int x, String value, bool byUser)
        {
            var coordString = "coord" + y + x;
            buttonsDictionary[coordString].Text = value;
            if (byUser)
            {
                buttonsDictionary[coordString].ForeColor = Color.Blue;
            }
        }
        /*
        //currently used for debugging
        internal void write(string s)
        {
            textBox1.Text += s;
        }*/

        internal void setInputNumber(InputNumber inputNumber)
        {
            iNum = inputNumber;
        }
        //simple way of mapping each button that corresponds to a box to a string version so outside classes can reference it
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

        //catchall for each of the box buttons, since they all work the same
        private void event_Click(object sender, EventArgs e)
        {
            Control button = (Control)sender;
            //only if the number in the box was placed in there by the user
            if (!notClickable.Contains(button)){
                //bring up the input number form and update its notes
                if (!iNum.IsDisposed)
                {
                    iNum.setNotes(gameController, button.Name.ToString());
                    iNum.resetFocus();
                    iNum.Show();
                }
                //if the user doesnt click go button and clicks X the iNum form is gone create a new one
                else
                {
                    iNum = new InputNumber(gameController, this);
                    iNum.setNotes(gameController, button.Name.ToString());
                    iNum.resetFocus();
                    iNum.Show();
                }
            }
            
        }
        //was running into the program not exiting when the x of this form was closed had to override
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

        //method for when the program is building the board it only lets the empty squares be clickable so user cant edit program placed numbers
        internal void setButtonClickable(int x, int y)
        {
            var coordString = "coord" + y + x;
            Control button = buttonsDictionary[coordString];
            notClickable.Remove(button);
        }
        //allows a button to be clicked and a number input form will be brought up
        internal void setButtonNotClickable(int y, int x)
        {
            var coordString = "coord" + y + x;
            Control button = buttonsDictionary[coordString];
            notClickable.Add(button);
        }
        //checks to see if user solved puzzle
        public void checkSolution()
        {
            //if they are correct give them the option of a new puzzle
            if (gameController.checkSolution())
            {
                CorrectSolution correct = new CorrectSolution(gameController);
                correct.Show();
            }
            else
            //tell them they are incorrect give them an option for a hint, to continue or a new puzzle
            {
                Incorrect incorrect = new Incorrect(gameController, this);
                incorrect.Show();
            }
        }
        
        private void solutionChecker_Click(object sender, EventArgs e)
        {
            checkSolution();
        }

        private void newPuzzleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameController.choseDifficulty();
        }
        //same code as button
        private void savePuzzleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkSolution();
        }

        private void hintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HintScreen hint = new HintScreen(gameController, this);
            hint.Show();
        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HowToPlayScreen howToPlayScreen = new HowToPlayScreen();
            howToPlayScreen.Show();
        }
    }
}
