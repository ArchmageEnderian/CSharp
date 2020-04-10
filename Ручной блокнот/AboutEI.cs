using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ручной_блокнот
{
    public partial class AboutEI : Form
    {
        public AboutEI()
        {
            InitializeComponent();
        }

        private void AboutEI_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            // треугольная форма
            myPath.AddPolygon(new Point[] { new Point(7, 7), new Point(this.Width-7, 7), new Point(this.Width-7, this.Height-8) });

            Region myRegion = new Region(myPath);
            this.Region = myRegion;
            richTextBox1.AppendText("                                                      Ручной блокнот создан Archmage『 Enderian 』\n                                                                    (Малахов Игорь Дмитриевич)\n                                                           Могут сделать все по желанию,\n                                                                             помним про бонус \n                                                                                       Хейтеры скажут фотошоп,\n                                                                                                              я скажу - \n                                                                                           плагиат оригинального\n                                                                                                          блокнота =D");
        }
    }
}
