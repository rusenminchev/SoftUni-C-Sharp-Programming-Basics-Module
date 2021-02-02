using System;

namespace Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int countFirst = 0;
            int countSecond = 0;
            int countThird = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    countFirst++;
                }
                if (number % 3 == 0)
                {
                    countSecond++;
                }
                if (number % 4 == 0)
                {
                    countThird++;
                }
            }
            double p1 = countFirst * 1.0 / n * 100;
            double p2 = countSecond * 1.0 / n * 100;
            double p3 = countThird * 1.0 / n * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
        }
    }
}
