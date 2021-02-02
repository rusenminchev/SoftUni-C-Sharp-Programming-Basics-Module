using System;

namespace _Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            double savedMoney = 0;
            double savedSum = 0;

            while (destination != "End")
            {
                double minBudget = double.Parse(Console.ReadLine());

                while (savedSum < minBudget)
                {
                    savedMoney = double.Parse(Console.ReadLine());
                    savedSum += savedMoney;
                }

                Console.WriteLine($"Going to {destination}!");
                savedSum = 0;
                destination = Console.ReadLine();
            }
        }
    }
}
