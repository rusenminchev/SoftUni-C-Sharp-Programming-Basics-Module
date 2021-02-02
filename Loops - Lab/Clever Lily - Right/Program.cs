using System;

namespace Clever_Lily___Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double laundryPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());


            int bDayMoney = 0;
            int moneyGift = 10;

            int Toyscount = 0;

            for (int currentBirthday = 1; currentBirthday <= age; currentBirthday++)
            {
                if (currentBirthday % 2 == 0)
                {
                    bDayMoney += moneyGift;
                    moneyGift += 10;
                    bDayMoney -= 1;
                }
                else
                {
                    Toyscount++;
                }

            }
            int moneyFromToys = Toyscount * toyPrice;
            bDayMoney += moneyFromToys;

            double difference = Math.Abs(bDayMoney - laundryPrice);

            if (bDayMoney >= laundryPrice)
            {
                
                Console.WriteLine($"Yes! {difference:f2}");
            }
            else
            {
               
                Console.WriteLine($"No! {difference:f2}");
            }
        }
    }
}
