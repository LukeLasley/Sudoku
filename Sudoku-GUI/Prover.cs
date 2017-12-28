using System;
using System.Collections.Generic;

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
            createListOfPoints();
            rand = new Random();
            if (emptyPoints.Count != 0) {
                for(int i =0; i < emptyPoints.Count; i++)
                {
                    possiblePoints.Remove(emptyPoints[i]);
                }
            }

        }

        //Duplicate code from board.cs please move
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

        public int removePoint()
        {
            if (possiblePoints.Count == 0)
            {
                return 0;
            }
            else
            {
                int indexChosen = rand.Next(possiblePoints.Count);
                Board copyBoard = board;
                copyBoard.remove(possiblePoints[indexChosen]);
                return solve(copyBoard);
            }
                
        }
        //implement solving
        private int solve(Board copyBoard)
        {
            throw new NotImplementedException();
        }
    }
}