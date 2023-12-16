using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, n];
            Random random = new Random();
            int maxRandom = 20;
            for(int i = 0; i < n; i++)
            {
                for(int k = 0; k < n; k++)
                {
                    arr[i, k] = random.Next(maxRandom);
                }
            }

            for (int i = 0; i < n; i++)
            {
                string line = "";
                for (int k = 0; k < n; k++)
                {
                    line = line + arr[i, k].ToString() + " ";
                }
                Console.WriteLine(line);
            }

            for (int i = 0; i < n; i++)
            {
                double sum = 0;
                for (int k = 0; k < n; k++)
                {
                    sum = sum + arr[i, k];
                }
                Console.WriteLine("Строка " + (i + 1) + ": " + sum / n);
            }

            Console.Read();
        }
    }
}
