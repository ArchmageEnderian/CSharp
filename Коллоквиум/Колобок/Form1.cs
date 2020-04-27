using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Колобок
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void generete(int M, int N, int[,] Matrix)
        {

            TB_1.Clear();
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Matrix[i, j] = rnd.Next(1, 99);
                }
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    TB_1.AppendText("[" + (i + 1) + "," + (j + 1) + "] = " + Matrix[i, j] + " ");
                }
                TB_1.AppendText("\n");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int M = System.Convert.ToInt32(textBox2.Text);
            int N = System.Convert.ToInt32(textBox1.Text);
            int[,] Matrix = new int[M, N];
            generete(M,N,Matrix);

            int K1 = System.Convert.ToInt32(textBox3.Text) - 1;
            int K2 = System.Convert.ToInt32(textBox4.Text) - 1;

            if (K1 >= K2 || K1 >= N || K2 > N)
            {
                MessageBox.Show("Ошибка условия!.\nПожалуйста, попробуйте еще раз.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for(int i = 0; i < N; i++)
                {
                    int Change = 0;
                    Change = Matrix[i, K1];
                    Matrix[i, K1] = Matrix[i, K2];
                    Matrix[i, K2] = Change;

                }
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        TB_2.AppendText("[" + (i + 1) + "," + (j + 1) + "] = " + Matrix[i, j] + " ");
                    }
                    TB_2.AppendText("\n");
                }
            }

            

        }

  
    }
}
