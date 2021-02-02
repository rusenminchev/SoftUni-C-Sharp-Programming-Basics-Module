using System;

namespace Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double oddMin = int.MaxValue;
            double oddMax = int.MinValue;

            double evenSum = 0;
            double evenMin = int.MaxValue;
            double evenMax = int.MinValue;

            double num = 0;

            for (int i = 1; i <= n; i++)
            {
                num = double.Parse(Console.ReadLine());

                if (i % 2 == 1)
                {
                    oddSum += num;
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                   
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }

                }
                if (i % 2 == 0)
                {
                    evenSum += num;
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }

                }

            }


                Console.WriteLine($"OddSum = {oddSum:f2}");
                Console.WriteLine($"OddMin = {oddMin:f2}");
                Console.WriteLine($"OddMax = {oddMax:f2}");
                Console.WriteLine($"EvenSum = {evenSum:f2}");
                Console.WriteLine($"EvenMin = {evenMin:f2}");
                Console.WriteLine($"EvenMax = {evenMax:f2}");
        }
    }
}
