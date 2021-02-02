using System;

namespace Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double laundryPrice = double.Parse(Console.ReadLine());
            int toysPrice = int.Parse(Console.ReadLine());


            double bDayMoney = 0;
            int numOfToys = 0;

            for (int i = 2; i <= age; i += 2)
            {
                bDayMoney = (i*5.00) - (i * 0.50);
            }

            for (int i = 1; i <= age; i += 2)
            {
                numOfToys ++;
            }

           

            double totalMoney = bDayMoney + (numOfToys * toysPrice);

            if (totalMoney >= laundryPrice)
            {
                double moneyLeft = totalMoney - laundryPrice;
                Console.WriteLine($"Yes! {moneyLeft}");
            }
            else
            {
                double moneyNeeded = laundryPrice - totalMoney;
                Console.WriteLine($"No! {moneyNeeded}");
            }
        }
    }
}
