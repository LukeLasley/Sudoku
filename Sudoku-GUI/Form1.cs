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
        public void updateCoord(int y, int x, String value)
        {
            var coordString = "coord" + y + x;
            buttonsDictionary[coordString].Text = value;
        }

        private void updateButtonDictionary()
        {
            foreach (Control control in this.Controls)
            {
                //richTextBox1.Text += control.Name.Substring(0, 4);
                if (control.GetType() == typeof(Button) && control.Name.Substring(0, 5).Equals("coord"))
                {
                    buttonsDictionary.Add(control.Name.ToString(), control);
                }
            }
        }

        public void updateRichText(String text)
        {
            richTextBox1.Text += text;
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
