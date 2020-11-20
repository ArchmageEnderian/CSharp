using System;
using System.IO;
using System.Collections.Generic;

namespace _2_Инда__Жуков
{
    class Program
    {
        static int n = 0;
        static List<int> list_on = new List<int>();
        static List<int> rez = new List<int>();

        static List<int> Dijkstra(int[,] matrix, int vert1)
        {
            List<int> dist = new List<int>(n);
            for (int i = 0; i < n; i++)
            {
                dist.Add(99999999);
            }
            dist[vert1] = 0;
            bool[] spec = new bool[n];
            for (int i = 0; i < n; i++) spec[i] = false;
            int minch = 99999999;
            int minind = 99999999;
            for (int i = 0; i < n; i++)
            {
                if(!spec[i] && (dist[i] < minch))
                {
                    minch = dist[i];
                    minind = i;
                }
            }
            if (minind != 99999999)
            {
                for (int i = 0; i < n; i++)
                {
                    if(matrix[minind, i] > 0)
                    {
                        int temp = minch + matrix[minind, i];
                        if (temp < dist[i])
                            dist[i] = temp;
                    }
                }
                spec[minind] = true;
            }
            while(minind < 99999999)
            {
                minch = 99999999;
                minind = 99999999;
                for (int i = 0; i < n; i++)
                {
                    if (!spec[i] && dist[i] < minch)
                    {
                        minch = dist[i];
                        minind = i;
                    }
                }
                if (minind != 99999999)
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (matrix[minind, i] > 0)
                        {
                            int temp = minch + matrix[minind, i];
                            if (temp < dist[i])
                                dist[i] = temp;
                        }
                    }
                    spec[minind] = true;
                }

            }
            return dist;
        }
        static int[] Degreeses(int[,] matrix)
        {

            int[] d = new int[n];
            for (int i = 0; i < n; i++)
            {
                int k = 0;
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i , j] > 0) k++;
                }
                d[i] = k;
            }
            return d;
        }

        static void Prov(List<int> listing, int[,] matrix, string[] range, bool[] on_off)
        {
            while(listing.Count != 0)
            {
                int vert = listing[0];
                on_off[vert] = true;
                List<int> paths = Dijkstra(matrix, vert);
                for (int i = 0; i < n; i++)
                {
                    int qq = Convert.ToInt32(range[vert]);
                    if(paths[i] <= qq && paths[i] > 0 && !on_off[i])
                    {
                        listing.Add(i);
                    }
                }
                listing.RemoveAt(0);
            }
        }
        static void Main(string[] args)
        {
            string path = @"D:\GitKraken\CSharp\2 Инда, Жуков\alarm1.txt", s;

            StreamReader sr = File.OpenText(path);
            n = Convert.ToInt32(sr.ReadLine());

            s = sr.ReadLine();
            string[] range = s.Split(' ');

            int[,] matrix = new int[n, n];
            for (int i = 0; i < n - 1; i++)
            {
                s = sr.ReadLine();
                string[] forMatr = s.Split(' ');
                int ii = Convert.ToInt32(forMatr[0]) - 1, jj = Convert.ToInt32(forMatr[1]) - 1;
                matrix[ii, jj] = Convert.ToInt32(forMatr[2]);
                matrix[jj, ii] = Convert.ToInt32(forMatr[2]);
            }

            /*Блок обработки графа*/

            int[] degre = new int[n];
            degre = Degreeses(matrix);
            int[,] costs = new int[2, n];
            for (int i = 0; i < n; i++) 
            {
                costs[0, i] = i;
                costs[1, i] = degre[i] * Convert.ToInt32(range[i]);
            }
            bool[] on_or_off = new bool[n];
            for (int i = 0; i < n; i++) on_or_off[i] = false;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if(costs[1,j] < costs[1,j + 1])
                    {
                        int swap = costs[1, j];
                        costs[1, j] = costs[1, j + 1];
                        costs[1, j + 1] = swap;
                        swap = costs[0, j];
                        costs[0, j] = costs[0, j + 1];
                        costs[0, j + 1] = swap;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                int vertex = costs[0, i];
                list_on.Clear();
                list_on.Add(vertex);
                if(!on_or_off[vertex])
                {
                    rez.Add(vertex);
                    Prov(list_on, matrix, range, on_or_off);
                }
            }


            StreamWriter sw = new StreamWriter(@"D:\GitKraken\CSharp\2 Инда, Жуков\alarmOUT.txt");
            sw.Write(Convert.ToString(rez.Count));
            sw.Close();
            sr.Close();
        }
    }
}
