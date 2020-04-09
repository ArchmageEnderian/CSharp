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
    public partial class ReWrite : Form
    {
        public ReWrite()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Data.Value = true;
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Data.Value = false;
            this.Close();
        }
    }
}
