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
            Application.SetCompatibleTextRenderingDefault(true);
            Form1 f = new Form1();
            GameController gameControl = new GameController(f);
            f.setGameController(gameControl);
            DifficultyChooser difficultyChooser = new DifficultyChooser(gameControl);
            difficultyChooser.Show();
            Application.Run();




        }
    }
}
