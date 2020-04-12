using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace База_телефонов
{
    public partial class Form1 : Form
    {
        private bool Format = false;
        private string[] Mas = new string[1000];
        public Form1()
        {
            InitializeComponent();
        }
        private void Situation1() // для +7-***-***-**-**
        {
            string UltraString = richTextBox1.Text;
            for (int i = 0; i < UltraString.Length - 1; i++)
            {
                if (UltraString[i] == '+' && UltraString[i+1] == '7')
                {


                }
            }





            MessageBox.Show("Сохранение прошло успешно!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Situation2() // для 8**********
        {

        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            if (checkBox.Checked == true)
            {

            }
            else
            {
                Situation1();
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
