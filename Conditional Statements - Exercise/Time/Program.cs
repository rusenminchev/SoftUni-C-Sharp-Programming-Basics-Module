using System;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());

            double sum = ((hours * 60) + mins + 15);
            double resultHours = sum / 60;

            if (resultHours >=24)
            {
                resultHours -= 24;
            }

            double resultMin = sum % 60;

            Console.WriteLine("{0:0}:{1:00}",resultHours,resultMin);
           

        }
    }
}
