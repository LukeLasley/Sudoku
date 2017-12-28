using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        private Dictionary<string,Control> buttonsDictionary;

        public Form1()
        {
            InitializeComponent();
            buttonsDictionary = new Dictionary<string, Control>();
            updateButtonDictionary();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        public void updateCoord(int y, int x, int value)
        {
            var coordString = "coord" + y + x;
            //Console.WriteLine(coordString);
            //Console.WriteLine(buttonsDictionary.Count);
            buttonsDictionary[coordString].Text = value.ToString();
        }

        private void updateButtonDictionary()
        {
            foreach (Control control in this.Controls)
            {
                richTextBox1.Text += control.Name.Substring(0, 4);
                if (control.GetType() == typeof(Button) && control.Name.Substring(0, 5).Equals("coord"))
                {
                    buttonsDictionary.Add(control.Name.ToString(), control);
                }
            }
        }

        private void coord35_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
