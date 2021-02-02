using System;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartPrice = 0;

            double studioTotal = 0;
            double apartTotal = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                studioTotal = nights * studioPrice;
                apartPrice = 65;
                apartTotal = nights * apartPrice;

                if (nights > 7 && nights <= 14)
                {
                    studioTotal *= 0.95;
                }
                else if (nights > 14)
                {
                    studioTotal *= 0.70;
                    apartTotal *= 0.90;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 75.20;
                studioTotal = nights * studioPrice;
                apartPrice = 68.70;
                apartTotal = nights * apartPrice;

                if (nights > 14)
                {
                    studioTotal *= 0.80;
                    apartTotal *= 0.90;
                }
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = 76;
                studioTotal = nights * studioPrice;
                apartPrice = 77;
                apartTotal = nights * apartPrice;

                if (nights > 14)
                {
                    apartTotal *= 0.90;
                }
            }
            Console.WriteLine($"Apartment: {apartTotal:f2} lv.");
            Console.WriteLine($"Studio: {studioTotal:f2} lv.");
        }
    }
}
