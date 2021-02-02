using System;

namespace Clever_Lily2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double laundryPrice = double.Parse(Console.ReadLine());
            int toysPrice = int.Parse(Console.ReadLine());


            int bDayMoneySum = 0;
            int moneyGift = 10;

            int numOfToys = 0;

            for (int currentBirthday = 1; currentBirthday <= age; currentBirthday ++)
            {
                if (age % 2 == 0)
                {
                    bDayMoneySum += moneyGift;
                    moneyGift += 10;
                    bDayMoneySum--;
                }
                else
                {
                    numOfToys++;
                }

            }
            int moneyFromToys = numOfToys * toysPrice;
            bDayMoneySum += moneyFromToys;

            Console.WriteLine(bDayMoneySum); 

        }
    }
}
