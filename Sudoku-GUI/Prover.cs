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
                possiblePoints.RemoveAt(indexChosen);
                return preProve(copyBoard, copyBoard.getPointList());
            }
                
        }
        //Preprocessor method to clean up some of the points the prover doesnt need to visit.
        private int preProve(Board copyBoard, List<Point> listOfPoints)
        {
            int leastOptions = copyBoard.getLeastPossibleOptions();
            //If there is a point with only one option, it will always be the same answer in every scenario.
            if (leastOptions == 1)
            {
                Point p = copyBoard.getLeastPossiblePoint();
                copyBoard.updateBoard(p.Y,p.X,board.getPossibleNumbers(p.Y, p.X)[0]);
                return preProve(copyBoard, copyBoard.getPointList());

            }
            //If there is a point with no options, somehow we have created a board with no answer.
            else if (leastOptions == 0)
            {
                return 0;
            }
            else
            {
                return prove(copyBoard);
            }
        }

        private int prove(Board copyBoard)
        {
            HashSet<List<Point>> permutations = getPermutations(copyBoard.getPointList());
            return 0;
        }

        private HashSet<List<Point>> getPermutations(List<Point>points)
        {
            HashSet <List<Point>> permutations = new HashSet<List<Point>>();
            if(points.Count == 1)
            {
                permutations.Add(points);
                return permutations;
            }
            else
            {
                for(int i= 0; i < points.Count; i++)
                {
                    List<Point> pointsRemaining = points;
                    Point curPoint = points[i];
                    pointsRemaining.Remove(curPoint);
                    HashSet<List<Point>> curPermutations = getPermutations(pointsRemaining);
                    foreach(List<Point> permute in curPermutations)
                    {
                        List<Point> permuteCopy = permute;
                        permuteCopy.Insert(0, curPoint);
                        permutations.Add(permuteCopy);
                    }

                }
                return permutations;
            }
        }
    }
}