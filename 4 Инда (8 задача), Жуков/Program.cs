using System;

namespace _4_Инда__8_задача___Жуков
{
    class Program
    {
        static bool Invertor(ref int[] inNums, int n, int d, int c)
        {
            for (int i = 0; i < inNums.Length; ++i)
            {
                inNums[i] -= c;
                while (inNums[i] <= 0 || inNums[i] % d != 0 && inNums[i] / d < n)
                    inNums[i] += n;

                if ((inNums[i] / d) > n)
                {
                    Console.WriteLine("NO");
                    return false;
                }
                inNums[i] /= d;
            }
            return true;
        }

        static void Main()
        {
            int n, d, c;
            int[] inNums;
            string input;

            /*Блок чтения и записи*/
            input = Console.ReadLine();
            n = Convert.ToInt32(input.Split()[0]);
            inNums = new int[Convert.ToInt32(input.Split()[1])];
            input = Console.ReadLine();
            d = Convert.ToInt32(input.Split()[0]);
            if (d <= 0) throw new DivideByZeroException();
            c = Convert.ToInt32(input.Split()[1]);
            input = Console.ReadLine();
            for (int i = 0; i < inNums.Length; ++i)
                inNums[i] = Convert.ToInt32(input.Split()[i]);
            Console.WriteLine();
            /*Конец блока чтения и записи*/

            if (Invertor(ref inNums, n, d, c))
            {
                Console.WriteLine("YES");
                foreach (int i in inNums)
                    Console.Write(i + " ");
            }
        }
    }

}
