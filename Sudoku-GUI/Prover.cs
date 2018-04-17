﻿using System;
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
        private List<List<Tuple<Point, int>>> solutions;

        public Prover(Board boardVar)
        {
            board = boardVar;
            emptyPoints = board.getPointList();
            possiblePoints = new List<Point>();
            createListOfPoints();

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