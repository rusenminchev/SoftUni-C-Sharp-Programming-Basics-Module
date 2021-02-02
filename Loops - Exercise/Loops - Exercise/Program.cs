using System;

namespace Loops___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            if (n > 1)
            {
                Console.WriteLine($"OddSum = {oddSum:f2}");
                Console.WriteLine($"OddMin = {oddMin:f2}");
                Console.WriteLine($"OddMax = {oddMax:f2}");
                Console.WriteLine($"EvenSum = {evenSum:f2}");
                Console.WriteLine($"EvenMin = {evenMin:f2}");
                Console.WriteLine($"EvenMax = {evenMax:f2}");
            }
            else
            {
                Console.WriteLine($"OddSum = {oddSum:f2}");
                Console.WriteLine($"No}");
                Console.WriteLine($"OddMax = {oddMax:f2}");
                Console.WriteLine($"EvenSum = {evenSum:f2}");
                Console.WriteLine($"EvenMin = {evenMin:f2}");
            }
    }
}
