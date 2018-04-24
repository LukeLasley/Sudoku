using System;
using System.Collections.Generic;
using System.Linq;

namespace Sudoku
{
    class Prover
    {
        private Board board;
        private List<Point> emptyPoints;
        private List<Point> possiblePoints;
        static Random rand;

        public Prover(Board boardVar)
        {
            board = boardVar;
            emptyPoints = board.getPointList();
            possiblePoints = new List<Point>();
            createListOfPoints();
        }
        //This method takes a clone of the board and goes through each unfilled box. If that box only has one solution the clone updates that box with the answer. 
        //If there is an iteration where no more boxes can be filled then it quits and returns what it could solve.
        private Board solve()
        {
            Board toSolve = board.clone();
            List<Point> unsolved = new List<Point>(toSolve.getPointList());
            bool iterationWithSolution = true;
            int i = 1;
            while (iterationWithSolution)
            {
                iterationWithSolution = false;
                List<Point> notRemoved = new List<Point>();
                foreach (Point p in unsolved)
                {
                    List<int> possibleValues = toSolve.getPossibleNumbers(p);
                    if (possibleValues.Count == 1)
                    {
                        iterationWithSolution = true;
                        toSolve.updateBoardNoGUI(p, possibleValues[0]);
                    }
                    else
                    {
                        notRemoved.Add(p);
                    }
                }
                unsolved = new List<Point>(notRemoved);
                i++;
            }
            return toSolve;
        }
        //This remover works under the principal that a good sudoku board never requires the solver to make a guess to put a number in a box.
        //might be a good idea to upate this to iterate over each 3x3 box and pick a box inside that to spread removes, easy and medium difficulties tend to leave some 3x3 boxes mostly full
        public void removePoints(int maxRemoves)
        {
            rand = new Random();
            int curRemoved = 0;
            while (curRemoved != maxRemoves && possiblePoints.Count != 0)
            {
                int randIndex = rand.Next(possiblePoints.Count);
                Point p = possiblePoints[randIndex];
                int valueAtP = board.getNumber(p);
                board.remove(p,false);
                //if the cloned board that was solved is completly filled then we know there is only 1 solution and the remove is valid.
                if (solve().getPointList().Count == 0)
                {
                    curRemoved++;
                }
                //if there are still unsolved boxes in the cloned board then there is no guarantee that there is only 1 solution
                //in theory you can write a complementary solver here, but it would require "guessing" a number in a box that might not lead to a solution. 
                else
                {
                    board.updateBoard(p, valueAtP,false);
                }
                possiblePoints.Remove(p);

            }
        }
        //initializer method to create a free pool of boxes.
        private void createListOfPoints()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    var p = new Point();
                    p.X = j;
                    p.Y = i;
                    possiblePoints.Add(p);
                }
            }
        }

    }
}