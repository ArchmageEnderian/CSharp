using System;
using System.IO;
using System.Collections.Generic;

namespace _3_Инда__Жуков
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> collection = new Dictionary<string, int>(3);
            string path = @"D:\GitKraken\CSharp\3 Инда, Жуков\Input.txt";
            StreamReader sr = File.OpenText(path);

            for(int i = 0; i < 3; i++)
            {
                string str = sr.ReadLine(), starter = "", s;
                for(int nw = 0; nw < 9; nw++)
                {
                    starter += Convert.ToString(str[nw]);
                }
                collection.Add(starter, Convert.ToInt32(Convert.ToString(str[10])));
            }

        }
    }
}
