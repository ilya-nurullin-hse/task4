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
            while (true)
            {
                Console.Write("Введите положительное число: ");
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    int sqrtN = (int) Math.Sqrt(n);
                    for (int i = 1; i <= sqrtN; i++)
                    {
                        for (int j = i; j <= sqrtN; j++)
                        {
                            int sum = sqrSum(i, j);
                            if (sum <= n)
                                Console.WriteLine(sum);
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
