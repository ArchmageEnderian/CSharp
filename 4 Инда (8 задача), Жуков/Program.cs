using System;
using System.IO;
using System.Collections.Generic;

namespace _4_Инда__8_задача___Жуков
{
    class Program
    {
        static int n, d, c;
        static bool Invertor(ref int[] inNums)
        {
            for (int i = 0; i < inNums.Length; ++i)
            {
                inNums[i] -= c;
                while (inNums[i] <= 0 || inNums[i] % d != 0 && inNums[i] / d < n)
                    inNums[i] += n;
                if ((inNums[i] / d) > n) return false;
                inNums[i] /= d;
            }
            return true;
        }

        static void Main()
        {
            int[] inNums; string input, path = @"D:\GitKraken\CSharp\4 Инда (8 задача), Жуков\innn.txt";

            /*Блок чтения и записи*/
            Console.WriteLine("Входные данные");
            StreamReader sr = File.OpenText(path);
            input = sr.ReadLine();
            Console.WriteLine(input);
            n = Convert.ToInt32(input.Split()[0]);
            inNums = new int[Convert.ToInt32(input.Split()[1])];
            input = sr.ReadLine();
            Console.WriteLine(input);
            d = Convert.ToInt32(input.Split()[0]);
            c = Convert.ToInt32(input.Split()[1]);
            input = sr.ReadLine();
            Console.WriteLine(input + "\n");
            for (int i = 0; i < inNums.Length; ++i)
                inNums[i] = Convert.ToInt32(input.Split()[i]);
            /*Конец блока чтения и записи*/

            sr.Close();
            StreamWriter sw = new StreamWriter(@"D:\GitKraken\CSharp\4 Инда (8 задача), Жуков\outtt.txt");

            /*Блок обработки данных*/
            if (Invertor(ref inNums))
            {
                sw.WriteLine("YES");
                foreach (int i in inNums) sw.Write(i + " ");
            }
            else sw.WriteLine("NO");
            sw.Close();
        }
    }
}
