using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Колобок2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            string s1 = textBox1.Text;
            char sq = '.';
            int indexOfChar = s1.IndexOf(sq);


            for(int i = indexOfChar + 1; i < s1.Length; i++)
            {
                char qw = s1[i];
                textBox2.AppendText(System.Convert.ToString(qw));
            }
        }
    }
}
