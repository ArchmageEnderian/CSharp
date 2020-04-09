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
            richTextBox1.AppendText("Ручной блокнот создан Archmage『 Enderian 』(Малахов Игорь Дмитриевич)\nСпециально для (Могут сделать все по желанию, помним про бонус)\nХейтеры скажут фотошоп, я скажу - плагиат оригинального блокнота");
        }
    }
}
