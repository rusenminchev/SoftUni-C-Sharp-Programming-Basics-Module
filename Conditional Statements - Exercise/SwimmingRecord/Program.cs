using System;

namespace SwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSecForOneMeterSwim = double.Parse(Console.ReadLine());

            double ivansTime = distanceInMeters * timeInSecForOneMeterSwim;

            double resistanceDelayInSeconds = Math.Floor(distanceInMeters / 15) * 12.5;
            

            double overallIvansTime = ivansTime + resistanceDelayInSeconds;
            double fail = overallIvansTime - record;

            if (overallIvansTime < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {overallIvansTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {fail:f2} seconds slower.");
            }
        }
    }
}
