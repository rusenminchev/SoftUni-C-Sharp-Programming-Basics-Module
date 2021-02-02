using System;

namespace _04._Easter_Eggs_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsPlayer1 = int.Parse(Console.ReadLine());
            int eggsPlayer2 = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "End of battle")
            {
          
                if (command == "one")
                {
                    eggsPlayer2--;
                }
                else if (command == "two")
                {
                    eggsPlayer1--;
                }

                if (eggsPlayer1 == 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {eggsPlayer2} eggs left.");
                    return;
                }
                else if (eggsPlayer2 == 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {eggsPlayer1} eggs left.");
                    return;
                }

                command = Console.ReadLine();

            }

            Console.WriteLine($"Player one has {eggsPlayer1} eggs left.");
            Console.WriteLine($"Player two has {eggsPlayer2} eggs left.");

        }
    }
}
