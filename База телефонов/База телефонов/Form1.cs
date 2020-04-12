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
        private string[] masString = new string[1000];
        private int j = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Situation1(string str, int counter) // для +7-***-***-**-**
        {
            bool flag = true;
            string TestStr = "";
            TestStr += "+7" + "-" + str[counter + 3] + str[counter + 4] + str[counter + 5] + "-" + str[counter + 7] + str[counter + 8] + str[counter + 9] + str[counter + 10] + str[counter + 11] + str[counter + 12] + str[counter + 13] + str[counter + 14] + str[counter + 15];
            for (int q = 0; q < j; q++)
                if (TestStr == masString[q]) flag = false;

            if (flag)
            {
                masString[j] += "+7" + "-" + str[counter + 3] + str[counter + 4] + str[counter + 5] + "-" + str[counter + 7] + str[counter + 8] + str[counter + 9] + str[counter + 10] + str[counter + 11] + str[counter + 12] + str[counter + 13] + str[counter + 14] + str[counter + 15];
                j++;
            }

        }
        private void Situation2(string str, int counter) // для 8**********
        {
            bool flag = true;
            string TestStr = "";
            TestStr += "8" + str[counter + 3] + str[counter + 4] + str[counter + 5] + str[counter + 7] + str[counter + 8] + str[counter + 9] + str[counter + 11] + str[counter + 12] + str[counter + 14] + str[counter + 15];
            for (int q = 0; q < j; q++)
                if (TestStr == masString[q]) flag = false;

            if (flag)
            {
                masString[j] += "8" + str[counter + 3] + str[counter + 4] + str[counter + 5] + str[counter + 7] + str[counter + 8] + str[counter + 9] + str[counter + 11] + str[counter + 12] + str[counter + 14] + str[counter + 15];
                j++;
            }
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            string ultraString = richTextBox1.Text;
            for (int i = 0; i < ultraString.Length - 1; i++)
            {
                if (ultraString[i] == '+' && ultraString[i + 1] == '7')
                {
                    if (checkBox.Checked == false || checkBox2.Checked == true) Situation1(ultraString, i);
                    else if (checkBox.Checked == true || checkBox2.Checked == false) Situation2(ultraString, i);
                    else 
                    if (checkBox.Checked == true || checkBox2.Checked == true)
                    {
                        // исключение
                    }

                }
            }


            MessageBox.Show("Сохранение прошло успешно!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RTBbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
