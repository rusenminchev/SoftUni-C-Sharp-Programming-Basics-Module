using System;

namespace _02._Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());

            double delayInSeconds = Math.Floor((distance * 1.0 / 50) * 30);

            double totalTime = (distance * timeForOneMeter) + delayInSeconds;

            if (totalTime < record)
            {
                Console.WriteLine($"Yes! The new record is {totalTime:f2} seconds.");
            }
            else
            {
                double diff = totalTime - record;
                Console.WriteLine($"No! He was {diff:f2} seconds slower.");
            }
        }
    }
}
