using System;
using System.Collections.Generic;
using System.Linq;

namespace Sudoku
{
    class Prover
    {
        private Board board;
        private Board boardClone;
        private List<Point> emptyPoints;
        private List<Point> possiblePoints;
        static Random rand;

        public Prover(Board boardVar)
        {
            board = boardVar;
            emptyPoints = board.getPointList();
            possiblePoints = new List<Point>();
            createListOfPoints();
            removePoints(75);
            
        }

        private Board preSolve()
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

        public bool solve()
        {
            Board toSolve = preSolve();
            if (toSolve.getPointList().Count == 0)
            {
                return true;
            }
            return false;
        }

        public void removePoints(int maxRemoves)
        {
            rand = new Random();
            int curRemoved = 0;
            while (curRemoved != maxRemoves && possiblePoints.Count != 0)
            {

                int randIndex = rand.Next(possiblePoints.Count);
                Point p = possiblePoints[randIndex];
                int valueAtP = board.getNumber(p);
                board.remove(p);
                if (solve())
                {
                    curRemoved++;
                }
                else
                {
                    board.updateBoard(p, valueAtP);
                }
                possiblePoints.Remove(p);

            }
            board.write(curRemoved.ToString());
        }

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