using System;
using System.Collections.Generic;
using System.Linq;

namespace Sudoku
{
    class Prover
    {
        private Board board;
        private Board copyBoard;
        private List<Point> emptyPoints;
        private List<Point> possiblePoints;
        static Random rand;

        public Prover(Board boardVar)
        {
            board = boardVar;
            emptyPoints = board.getPointList();
            possiblePoints = new List<Point>();
            createListOfPoints();
            List<List<Point>> permutes = getPermutations(boardVar.getPointList());
            for(int i = 0;i< permutes.Count; i++)
            {
                for(int j = 0;j<permutes[i].Count; j++)
                {
                    boardVar.write(permutes[i][j].printPoint());
                }
                boardVar.write("\r\n");
            }
            Board t = boardVar.clone();
            List<List<int>> solu = getSolutions(permutes[0], t);
            for(int i =0; i<solu.Count; i++)
            {
                for(int j = 0; j < solu[i].Count; j++)
                {
                    boardVar.write(solu[i][j].ToString());
                    boardVar.write(",");
                }
                boardVar.write("\r\n");
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

        public List<List<int>> getSolutions(List<Point> coordinates, Board tempBoard)
        {
            List<List<int>> solutions = new List<List<int>>();
            if(coordinates.Count == 1)
            {
                Point p = coordinates[0];
                solutions.Add(tempBoard.getPossibleNumbers(p.Y, p.X));
            }
            else
            {
                Point p = coordinates[0];
                List<Point> curCoordinates = new List<Point>(coordinates);
                curCoordinates.Remove(p);
                List<int> possibleSolutions = tempBoard.getPossibleNumbers(p.Y,p.X);
                for(int i =0; i< possibleSolutions.Count; i++)
                {
                    tempBoard.updateBoard(p.Y, p.X, possibleSolutions[i]);
                    List<List<int>> recursiveSolutions = getSolutions(curCoordinates, tempBoard);
                    foreach (List<int> solution in recursiveSolutions)
                    {
                        List<int> solutionCopy = new List<int>(solution);
                        solutionCopy.Insert(0, possibleSolutions[i]);
                        solutions.Add(solutionCopy);
                    }
                    tempBoard.remove(p);
                }

            }
            return solutions;
        }

        public List<List<Point>> getPermutations(List<Point>points)
        {
            List <List<Point>> permutations = new List<List<Point>>();
            if(points.Count == 1)
            {
                permutations.Add(points);
                return permutations;
            }
            else
            {
                for(int i= 0; i < points.Count; i++)
                {
                    List<Point> pointsRemaining = new List<Point>(points);
                    Point curPoint = points[i];
                    pointsRemaining.Remove(curPoint);
                    List<List<Point>> curPermutations = getPermutations(pointsRemaining);
                    foreach (List<Point> permute in curPermutations)
                    {
                        List<Point> permuteCopy = new List<Point>(permute);
                        permuteCopy.Insert(0, curPoint);
                        permutations.Add(permuteCopy);
                    }
                }

                return permutations;
            }
        }
    }
}