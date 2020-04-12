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
        private bool check = false;
        public Form1()
        {
            InitializeComponent();
            checkBox2.Checked = true;
        }
        private void RTBfillup()
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
            richTextBox1.Clear();
            for (int i = 0; i < j; i++)
            {
                richTextBox1.AppendText(masString[i] + "\n");
            }
            check = true;
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
            saveFileDialog1.Filter = " txt files (*txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                if (!check) RTBfillup();
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show("Сохранение прошло успешно!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ошибка сохранения файла.\nПожалуйста, попробуйте еще раз.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            saveFileDialog1.FileName = "";
            check = false;
            for (int i = 0; i < j; i++)
            {
                masString[i] = null;
            }
            j = 0;
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RTBbutton_Click(object sender, EventArgs e)
        {
            RTBfillup();
        }
    }
}
