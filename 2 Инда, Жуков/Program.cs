using System;
using System.IO;

namespace _2_Инда__Жуков
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\GitKraken\CSharp\2 Инда, Жуков\alarm.txt";
            int n = 0;
            StreamReader sr = File.OpenText(path);
            string s;
            n = Convert.ToInt32(sr.ReadLine());
            s = sr.ReadLine();
            string[] range = s.Split(' ');
            int[,] Matrix = new int[n, n];
            for (int i = 0; i < n - 1; i++)
            {
               s = sr.ReadLine();
               string[] forMatr = s.Split(' ');
               int ii = Convert.ToInt32(forMatr[0]) - 1, jj = Convert.ToInt32(forMatr[1]) - 1;
               Matrix[ii, jj] = Convert.ToInt32(forMatr[2]);
            } 

            
        }
    }
}
