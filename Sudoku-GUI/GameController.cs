using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class GameController
    {
        private Board curBoard;
        private BoardBuilder builder;
        private Prover prover;
        private Form1 gui;

        public GameController(Form1 f)
        {
            gui = f;
            curBoard = new Board(gui);
            builder = new BoardBuilder(curBoard);
            builder.populateBoard();
            prover = new Prover(curBoard);
        }

        public void createEasyGame()
        {
            prover.removePoints(25);
            gui.Show();
        }

        public void createMediumGame()
        {
            prover.removePoints(45);
            gui.Show();
        }

        public void createHardGame()
        {
            prover.removePoints(64);
            gui.Show();
        }

    }
}
