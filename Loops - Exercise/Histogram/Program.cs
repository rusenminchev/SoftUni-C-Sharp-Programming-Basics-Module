using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int countFirst = 0;
            int countSecond = 0;
            int countThird = 0;
            int countForth = 0;
            int countFifth = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    countFirst++;
                }
                else if (number >= 200 && number <= 399)
                {
                    countSecond++;
                }
                else if (number >= 400 && number <= 599)
                {
                    countThird++;
                }
                else if (number >= 600 && number <= 799)
                {
                    countForth++;
                }
                else if (number >= 800)
                {
                    countFifth++;
                }
            }
            double p1 = countFirst * 1.0 / n * 100;
            double p2 = countSecond * 1.0 / n * 100;
            double p3 = countThird * 1.0 / n * 100;
            double p4 = countForth * 1.0 / n * 100;
            double p5 = countFifth * 1.0 / n * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
