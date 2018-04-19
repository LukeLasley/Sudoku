using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class BoardBuilder
    {
        private Board board;

        public BoardBuilder(Board boardVar)
        {
            board = boardVar;
            board.createListOfPoints();
        }

        public void populateBoard()
        {
            var listOfPoints = board.getPointList();
            {
                while (listOfPoints.Count > 0)
                {
                    var p = board.getLeastPossiblePoint();
                    var possibleNumbers = board.getPossibleNumbers(p);
                    if (possibleNumbers.Count > 0)
                    {
                        var rand = new Random();
                        var index = rand.Next(possibleNumbers.Count);
                        board.updateBoard(p, possibleNumbers[index]);
                        listOfPoints.Remove(p);
                    }
                    else
                    {
                        board.clearBoard();
                        listOfPoints = board.getPointList();
                    }

                }
            }
        }
    }
}
