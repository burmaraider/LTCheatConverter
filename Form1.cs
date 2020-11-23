using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTCheatConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Convert to lowercase
            textBox1.Text.ToLower();

            //Get make a char array
            char[] charArr = textBox1.Text.ToCharArray();

            //mangle it
            for (uint i = 0; i < charArr.Length; i++)
                charArr[i] = (char)(((charArr[i] ^ 38) + i) ^ 7);

            //Spit it out
            textBox1.Text = new string(charArr);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
