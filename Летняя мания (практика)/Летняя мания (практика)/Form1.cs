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
        private const double Eps = 0.0001;
        private bool F_try = true;
        private int N = 100;
        public Form1()
        {
            InitializeComponent();
            UravnLabel.Text = "X";
        }
        private double func(double x)
        {
            return (x);
        }
        private double simpson(double a, double b)
        {
            double s1 = simpsonIntegral(a, b), s;
            do
            {
                s = s1;     
                N = 2 * N;  
                s1 = simpsonIntegral(a, b);
            }
            while (Math.Abs(s1 - s) > Eps);
            return s1;
        }
        private double simpsonIntegral(double a, double b)
        {
            double h = (b - a) / N;
            double k1 = 0, k2 = 0;
            for (int i = 1; i < N; i += 2)
            {
                k1 += func(a + i * h);
                k2 += func(a + (i + 1) * h);
            }
            return h / 3 * (func(a) + 4 * k1 + 2 * k2);
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
            Stopwatch Stp = new Stopwatch();
            double a = Convert.ToDouble(AtextBox.Text);
            double b = Convert.ToDouble(BtextBox.Text);
            Stp.Start();
            double Otvet1 = simpson(Convert.ToDouble(AtextBox.Text), Convert.ToDouble(BtextBox.Text));
            double Fotvet = Math.Round(Otvet1 * 1000) / 1000;
            double X1 = -9, X2 = 10, Rez = 0.0, Y = 0.0;

            double X = sek(X1, X2, Rez, Y);
            Stp.Stop();
            TimeSpan ts = Stp.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

            MessageBox.Show("Интеграл = " + Fotvet + "\nДопустимая погрешность = " + Eps + "\nX = " + X + "\nВремя - " + elapsedTime, "Результаты");
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            starter();
        }
    }
}
