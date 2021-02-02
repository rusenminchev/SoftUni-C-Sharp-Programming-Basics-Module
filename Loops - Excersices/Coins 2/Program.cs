using System;

namespace Coins_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());

            double changeSt = Math.Floor(change * 100);

            int coinCounter = 0;

            while (changeSt > 0)
            {
                if (changeSt >= 200)
                {
                    coinCounter++;
                    changeSt -= 200;

                }
                else if (changeSt >= 100)
                {
                    coinCounter++;
                    changeSt -= 100;

                }
                else if (changeSt >= 50)
                {
                    coinCounter++;
                    changeSt -= 50;

                }
                else if (changeSt >= 20)
                {
                    coinCounter++;
                    changeSt -= 20;

                }
                else if (changeSt >= 10)
                {
                    coinCounter++;
                    changeSt -= 10;

                }
                else if (changeSt >= 5)
                {
                    coinCounter++;
                    changeSt -= 5;

                }
                else if (changeSt >= 2)
                {
                    coinCounter++;
                    changeSt -= 2;

                }
                else if (changeSt >= 1)
                {
                    coinCounter++;
                    changeSt -= 1;

                }
            }

            Console.WriteLine(coinCounter);

        }
    }
}
