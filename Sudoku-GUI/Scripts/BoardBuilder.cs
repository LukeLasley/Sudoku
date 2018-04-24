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
        //this starts on an empty board and ends with a fully filled out board
        public void populateBoard()
        {
            var listOfPoints = board.getPointList();
            {
                while (listOfPoints.Count > 0)
                {
                    //get the box with the least amount of possible solutions
                    var p = board.getLeastPossiblePoint();
                    var possibleNumbers = board.getPossibleNumbers(p);
                    //if there are solutions grab a random one and place it
                    if (possibleNumbers.Count > 0)
                    {
                        var rand = new Random();
                        var index = rand.Next(possibleNumbers.Count);
                        board.updateBoard(p, possibleNumbers[index],false);
                        listOfPoints.Remove(p);
                    }
                    //can occur when there is a box with no solution. Wipe the board and try again
                    //could so some sort of undoing but that might be a bit overkill
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
