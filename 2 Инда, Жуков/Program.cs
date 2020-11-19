using System;
using System.IO;

namespace _2_Инда__Жуков
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Университет\Жуков\2 Инда, Жуков\alarm.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
        }
    }
}
