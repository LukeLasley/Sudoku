using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 f = new Form1();
            f.Text = "Sudoku";
            Board b = new Board(f);
            BoardBuilder builder = new BoardBuilder(b);
            builder.populateBoard();
            Point p = new Point();
            Prover prover = new Prover(b);
            p.X = 3;
            p.Y = 4;
            b.remove(p);
            p.Y = 5;
            b.remove(p);
            p.X = 8;
            b.remove(p);
            List<List<Point>>permutations = prover.getPermutations(b.getPointList());
            for(int i = 0; i< permutations.Count; i++)
            {
                List<Point> curPermutation = permutations[i];
                for (int j = 0; j < curPermutation.Count; j++)
                {
                    b.write(curPermutation[j].printPoint());
                }
                b.write("\r\n");
            }
            b.write("A");
            Application.Run(f);
            


        }
    }
}
