using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "Дано натуральное число n. Среди чисел 1,2,...,n найти все те, которые можно представить в виде суммы квадратов двух " +
                "натуральных чисел. (Определить процедуру, позволяющую распознавать полные квадраты).\n");
            while (true)
            {
                Console.Write("Введите положительное число: ");
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    int sqrtN = (int) Math.Sqrt(n);
                    var printed = new List<int>();
                    for (int i = 1; i <= sqrtN; i++)
                    {
                        for (int j = i; j <= sqrtN; j++)
                        {
                            int sum = sqrSum(i, j);
                            if (sum <= n && !printed.Contains(sum))
                            {
                                Console.WriteLine(sum);
                                printed.Add(sum);
                            }
                        }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ожидалось положительное число");
                }
            }
        }

        static int sqrSum(int x, int y)
        {
            return x * x + y * y;
        }
    }
}
