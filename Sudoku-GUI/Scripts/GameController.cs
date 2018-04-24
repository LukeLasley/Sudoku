using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public class GameController
    {
        private Board curBoard;
        private BoardBuilder builder;
        private Prover prover;
        private Form1 gui;
        private Dictionary<string, string> notesDictionary;
        private int[,] solution;

        public GameController(Form1 f)
        {
            gui = f;
            curBoard = new Board(gui);
            builder = new BoardBuilder(curBoard);
            builder.populateBoard();
            solution = (int[,])curBoard.getPoints().Clone();
            prover = new Prover(curBoard);
            //the notesDictionary is where the notes for each box is stored
            notesDictionary = new Dictionary<string, string>();
        }
        internal string getNotes(string button)
        {
            return notesDictionary[button];
        }

        internal void setCoord(string curButton, string text)
        {
            Point p = new Point();
            p.Y = (int)char.GetNumericValue(curButton[5]);
            p.X = (int)char.GetNumericValue(curButton[6]);
            if(text.Length == 0)
            {
                curBoard.remove(p, true);
            }
            else
            {
                //Try catch needed to catch if user inputs non number. If it catches it then just ignore what the user put in. 
                try
                {
                    int answer = Convert.ToInt32(text);
                    curBoard.updateBoard(p, answer, true);
                }
                catch(System.FormatException exception)
                {

                }
            }
        }
        //Following methods create a game by removing a set amount of boxes
        public void createEasyGame()
        {
            prover.removePoints(35);
            gui.Show();
        }

        public void createMediumGame()
        {
            prover.removePoints(45);
            gui.Show();
        }
        //Removing 64 is the max amount of boxes you can remove, any more will cause the puzzle to lose its single solution
        public void createHardGame()
        {
            prover.removePoints(64);
            gui.Show();
        }

        internal void updateNoteDictionary(string button, string text)
        {
            notesDictionary[button] = text;
        }

        //compares the original board solution to the solution placed in the current board.
        public bool checkSolution()
        {
            int[,] curAnswer = curBoard.getPoints();
            for(int i =0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (solution[i, j] != curAnswer[i, j]) {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
