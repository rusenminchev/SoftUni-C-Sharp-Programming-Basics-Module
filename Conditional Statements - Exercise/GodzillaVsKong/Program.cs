using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double filmBudget = double.Parse(Console.ReadLine());
            int extra = int.Parse(Console.ReadLine());
            double costumePrice = double.Parse(Console.ReadLine());

            double movieSet = filmBudget * 0.10;


            if (extra > 150)
            {
                costumePrice = costumePrice - costumePrice * 0.10;
            }
            double extraPrice = extra * costumePrice;
            double expenses = movieSet + extraPrice;
           
            double notEnoughBudget = expenses - filmBudget;
            double enoughBudget = filmBudget - expenses;
            if (filmBudget < expenses)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {notEnoughBudget:f2} leva more.");

            }
            else
                        {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {enoughBudget:f2} leva left.");
            }


        }   
    }
}
