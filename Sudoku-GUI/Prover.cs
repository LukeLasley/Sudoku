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

        public bool solve()
        {
            return false;
        }

        public void removePoints(int maxRemoves)
        {
            rand = new Random();
            int curRemoved = 0;
            while(curRemoved != maxRemoves && possiblePoints.Count != 0)
            {
                int randIndex = rand.Next(possiblePoints.Count);
                Point p = possiblePoints[randIndex];
                int valueAtP = board.getNumber(p.Y, p.X);
                board.remove(p);
                if (proveRemove())
                {
                    curRemoved++;
                }
                else
                {
                    board.updateBoard(p.Y, p.X, valueAtP);
                }
                possiblePoints.Remove(p);
            }
            //board.write(possiblePoints.Count.ToString());
        }

        internal void removeFromClone()
        {
            Board b = board.clone();
            Point p = new Point();
            p.X = 3;
            p.Y = 4;
            b.removeNoGUI(p);
        }

        private bool proveRemove()
        {
            Board boardClone = board.clone();
            List<List<Point>> curPermutations = getPermutations(board.getPointList());
            List<List<int>> curSolutions = getSolutions(curPermutations[0], boardClone);
            List<Point> permutationToCompare = curPermutations[0];
            for (int i = 1; i < curPermutations.Count; i++)
            {
                List<List<int>> solutionsToCompare = getSolutions(curPermutations[i], boardClone);
                if(solutionsToCompare.Count > 1)
                {
                    return false;
                }
                if(comparePermutations(permutationToCompare, curPermutations[i], curSolutions, solutionsToCompare) == false)
                {
                    return false;
                }
                if(solutionsToCompare.Count > 0)
                {
                    permutationToCompare = new List<Point>(curPermutations[i]);
                    curSolutions = new List<List<int>>(solutionsToCompare);
                }

            }
            return true;
        }

        private bool comparePermutations(List<Point> permutationA, List<Point> permutationB, List<List<int>> solutionA, List<List<int>> solutionB)
        {
            if(solutionB.Count == 0 || solutionA.Count == 0)
            {
                return true;
            }
            for(int i =0; i < permutationA.Count(); i++)
            {
                int permutationBIndex = permutationB.IndexOf(permutationA[i]);
                if(solutionA[0][i] != solutionB[0][permutationBIndex])
                {
                    return false;
                }
            }
            return true;
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