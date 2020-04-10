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



namespace Ручной_блокнот
{

    public partial class Form1 : Form
    {
        public bool ReWriteBool = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\Desktop\\NotepadFile.txt", "");
        }

        private void AboutProgrammToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutEI WindowOpen = new AboutEI();
            WindowOpen.ShowDialog();
        }

        private void LoadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream file1 = new FileStream("C:\\Users\\" + Environment.UserName + "\\Desktop\\NotepadFile.txt", FileMode.Open);
                StreamReader reader = new StreamReader(file1);
                richTextBox1.Clear();
                richTextBox1.AppendText(reader.ReadToEnd());
                file1.Close();
            }
            catch
            {
                LoadError error = new LoadError();
                error.ShowDialog();
            }

        }

        private void SaveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(File.Exists("C:\\Users\\" + Environment.UserName + "\\Desktop\\NotepadFile.txt"))
            {
                Data.Value = false;
                ReWrite Rewriter = new ReWrite();
                Rewriter.ShowDialog();
                if (Data.Value)
                {
                    FileStream file1 = new FileStream("C:\\Users\\" + Environment.UserName + "\\Desktop\\NotepadFile.txt", FileMode.Create);
                    StreamWriter writer = new StreamWriter(file1);
                    writer.Write(richTextBox1.Text);
                    writer.Close();
                }
            }
            else
            {
                FileStream file1 = new FileStream("C:\\Users\\" + Environment.UserName + "\\Desktop\\NotepadFile.txt", FileMode.Create);
                StreamWriter writer = new StreamWriter(file1);
                writer.Write(richTextBox1.Text);
                writer.Close();
            }

            
        }

        private void DeleteFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete("C:\\Users\\" + Environment.UserName + "\\Desktop\\NotepadFile.txt");
        }
    }
    static class Data
    {
        public static bool Value { get; set; }
    }
}
