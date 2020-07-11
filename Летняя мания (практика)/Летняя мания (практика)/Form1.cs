using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Летняя_мания__практика_
{
    public partial class Form1 : Form
    {
        private const double Eps = 0.001;
        private bool F_try = true;
        private double a = 0.0;
        private double b = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private double func(double x)
        {
            return (x);
        }

        private double simpson()
        {
            return 0;
        }

        private double sek(double X1, double X2, double Rez, double Y)
        {
            do
            {
                double Ex1 = 0.0, Ex2 = 0.0;
                Ex2 = simpson(0, X2);
                Ex1 = simpson(0, X1);
                Y = Rez;
                if (Ex2 == Ex1)
                {
                    X1 = 1;
                }
                if (F_try)
                {
                    for (int i = -1; i < 3; i++)
                       if (simpson(0, i) == 0) return i;
                    F_try = false;
                }
            } while (Math.Abs(Y - Rez) >= Eps);
            return Rez;
        }
        private void starter()
        {
            int N = 1;
            Stopwatch Stp = new Stopwatch();
            Stp.Start();
            double Otvet1 = simpson(Convert.ToDouble(AtextBox.Text), Convert.ToDouble(BtextBox.Text));
            double Fotvet = Math.Round(Otvet1 * 1000) / 1000;
            double X1 = -9, X2 = 10, Rez = 0.0, Y = 0.0;

            double X = sek(X1, X2, Rez, Y);
            MessageBox.Show("Интеграл = " + Fotvet + "\nДопустимая погрешность = " + Eps + "\nX = " + X);
            Stp.Stop();
        }
    }
}
