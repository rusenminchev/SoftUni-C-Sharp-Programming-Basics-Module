using System;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double total = 0;

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (num >= 0)
                {
                    Console.WriteLine($"Increase: {num:f2}");
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                total += num;
            }
            
            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
