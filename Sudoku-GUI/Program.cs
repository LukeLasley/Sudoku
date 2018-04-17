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
            Application.Run(f);
            


        }
    }
}
