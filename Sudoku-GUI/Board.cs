using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    class Board
    {
        private int[,] board = new int[9, 9];
        private List<Point> listOfPoints = new List<Point>();
        private Form1 f;

        public Board(Form1 f)
        {
            this.f = f;
        }

        //Returns all possible numbers that can go in the box of the coordinate.
        //TODO: have this take a Point instead of an y and x
        public List<int> getPossibleNumbers(int y, int x)
        {
            var possibleNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var rowNumbs = getRow(y);
            var colNumbs = getColumn(x);
            var squareNumbs = getSquare(y, x);
            rowNumbs.AddRange(colNumbs);
            rowNumbs.AddRange(squareNumbs);
            for (int i = 0; i < rowNumbs.Count; i++)
            {
                if (possibleNumbers.Contains(rowNumbs[i]))
                {
                    possibleNumbers.Remove(rowNumbs[i]);
                }
            }
            return possibleNumbers;
        }

        //Gets all numbers currently in row that are not empty
        //TODO: change to take in a point
        public List<int> getRow(int y)
        {
            var rowList = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                if (board[y, i] != 0)
                {
                    rowList.Add(board[y, i]);
                }
            }

            return rowList;
        }
        
        //Removes number placed in the coordinate
        internal void remove(Point point)
        {
            listOfPoints.Add(point);
            board[point.Y, point.X] = 0;
            f.updateCoord(point.Y, point.X, "");
        }

        //Gets all numbers currently in column that are not empty
        //TODO: change to take in a point
        public List<int> getColumn(int x)
        {
            var rowList = new List<int>();

            for (int i = 0; i < 9; i++)
            {
                if (board[i, x] != 0)
                {
                    rowList.Add(board[i, x]);
                }
            }
            return rowList;
        }

        //Gets all numbers currently in the 3x3 box that are not empty
        //TODO: change to take in a point
        public List<int> getSquare(int y, int x)
        {
            var xStart = (x / 3) * 3;
            var yStart = (y / 3) * 3;
            var squaresList = new List<int>();
            for (int i = xStart; i < xStart + 3; i++)
            {
                for (int j = yStart; j < yStart + 3; j++)
                {
                    if (board[j, i] != 0)
                    {
                        squaresList.Add(board[j, i]);
                    }
                }
            }

            return squaresList;
        }
        //Sets the value to what is at the coordinate.
        //TODO: change to take in a point
        public void updateBoard(int y, int x, int val)
        {
            var p = new Point();
            p.X = x;
            p.Y = y;
            listOfPoints.Remove(p);
            board[y, x] = val;
            f.updateCoord(y, x, val.ToString());
        }
        //Wipes the board
        public void clearBoard()
        {
            board = new int[9, 9];
            createListOfPoints();
        }
        //Gets what value is at the point
        //TODO: change to take in point
        public int getNumber(int y, int x)
        {
            return board[y, x];
        }

        //Returns all empty points
        public List<Point> getPointList()
        {
            return listOfPoints;

        }

        //Gives the point with the smallest amount of possible values 
        public Point getLeastPossiblePoint()
        {
            var p = listOfPoints[0];
            var possiblePointSize = getPossibleNumbers(p.Y, p.X).Count;
            for (int i = 0; i < listOfPoints.Count; i++)
            {
                var loopPoint = listOfPoints[i];
                var loopPointPossibleSize = getPossibleNumbers(loopPoint.Y, loopPoint.X).Count;
                if (loopPointPossibleSize < possiblePointSize)
                {
                    p = loopPoint;
                    possiblePointSize = loopPointPossibleSize;
                }
            }
            return p;
        }
        //TODO: Check what this was for
        public int getLeastPossibleOptions()
        {
            var p = listOfPoints[0];
            var possiblePointSize = getPossibleNumbers(p.Y, p.X).Count;
            for (int i = 0; i < listOfPoints.Count; i++)
            {
                var loopPoint = listOfPoints[i];
                var loopPointPossibleSize = getPossibleNumbers(loopPoint.Y, loopPoint.X).Count;
                if (loopPointPossibleSize < possiblePointSize)
                {
                    p = loopPoint;
                    possiblePointSize = loopPointPossibleSize;
                }
            }
            return possiblePointSize;
        }
        //Creates initial empty list of all points
        public void createListOfPoints()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    var p = new Point();
                    p.X = j;
                    p.Y = i;
                    listOfPoints.Add(p);
                }
            }
        }
        //Temporary logging method
        //TODO: Delete once board creation is complete
        public void write(String s)
        {
            f.updateRichText(s);
        }

        //TODO: Might be cause of board not cloning
        private void setPoints(int[,] points)
        {
            this.board = points;
        }

        //Clones board so edits dont change original board
        //Still kinda works please investigate it
        public Board clone()
        {
            Board clone = new Board(f);
            clone.setPoints(this.board);
            return clone;
        }

    }
}
public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }
    public string printPoint()
    {
        return X + "," + Y + " ";
    }
}