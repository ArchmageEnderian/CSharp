using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
        private bool IsNumber(char str1)
        {
            string str = str1.ToString();
            int Num;
            bool isNum = int.TryParse(str, out Num);
            return isNum;
        }
        private void RTBfillup()
        {
            string ultraString = richTextBox1.Text;
            for (int i = 0; i < ultraString.Length - 15; i++)
            {
                if (ultraString[i] == '+'  && IsNumber(ultraString[i + 1]) && (ultraString[i + 2] == ' ' || ultraString[i + 2] == '-') && IsNumber(ultraString[i + 3]) && IsNumber(ultraString[i + 4]) && IsNumber(ultraString[i + 5]) && (ultraString[i + 6] == ' ' || ultraString[i + 6] == '-') && IsNumber(ultraString[i + 7]) && IsNumber(ultraString[i + 8]) && IsNumber(ultraString[i + 9]) && (ultraString[i + 10] == ' ' || ultraString[i + 10] == '-') && IsNumber(ultraString[i + 11]) && IsNumber(ultraString[i + 12]) && (ultraString[i + 13] == ' ' || ultraString[i + 13] == '-') && IsNumber(ultraString[i + 14]) && IsNumber(ultraString[i + 15]))
                {
                    if (checkBox.Checked == false && checkBox2.Checked == true) Situation1(ultraString, i);
                    else if (checkBox.Checked == true && checkBox2.Checked == false) Situation2(ultraString, i);
                    else
                    if (checkBox.Checked == true && checkBox2.Checked == true)
                    {
                        Situation3(ultraString, i);
                    }
                    i += 15;
                }
            }
            richTextBox1.Clear();
            for (int i = 0; i < j; i++)
            {
                richTextBox1.AppendText(masString[i] + "\n");
            }
            check = true;
            for (int i = 0; i < j; i++)
            {
                masString[i] = null;
            }
            j = 0;
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
        private void Situation3(string str, int counter) // для обоих случаев
        {
            bool flag = true;
            string TestStr = "";
            TestStr += "+7" + "-" + str[counter + 3] + str[counter + 4] + str[counter + 5] + "-" + str[counter + 7] + str[counter + 8] + str[counter + 9] + str[counter + 10] + str[counter + 11] + str[counter + 12] + str[counter + 13] + str[counter + 14] + str[counter + 15];
            for (int q = 0; q < j; q++)
                if (TestStr == masString[q]) flag = false;

            if (flag)
            {
                masString[j] += "+7" + "-" + str[counter + 3] + str[counter + 4] + str[counter + 5] + "-" + str[counter + 7] + str[counter + 8] + str[counter + 9] + str[counter + 10] + str[counter + 11] + str[counter + 12] + str[counter + 13] + str[counter + 14] + str[counter + 15] + " || " + "8" + str[counter + 3] + str[counter + 4] + str[counter + 5] + str[counter + 7] + str[counter + 8] + str[counter + 9] + str[counter + 11] + str[counter + 12] + str[counter + 14] + str[counter + 15];
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

        private void ОтчиститьОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void ОПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мой создатель Archmage 『 Enderian 』\n(Также известен миру как Малахов Игорь Дмитриевич)\nВерсия программы: BetaBuild V1.17", "Мой создатель", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SevenFormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkBox.Checked = false;
            checkBox2.Checked = true;
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

        private void EightFormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkBox.Checked = true;
            checkBox2.Checked = false;
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

        private void ВОбоихФорматахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkBox.Checked = true;
            checkBox2.Checked = true;
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

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "C:\\Users\\" + Environment.UserName + "\\Desktop\\";
            openFileDialog1.Filter = " txt files(*txt) | *.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                        }
                    }
                }
                catch (Exception ep)
                {
                    MessageBox.Show("Ошибка открытия файла!","Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
