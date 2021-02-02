using System;

namespace Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());

            if (city == "Sofia")
            {
                if (volume >= 0 && volume <= 500)
                {
                    double commission = volume * 0.05;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (volume > 500 && volume <= 1000)
                {
                    double commission = volume * 0.07;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (volume > 1000 && volume <= 10000)
                {
                    double commission = volume * 0.08;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (volume > 10000)
                {
                    double commission = volume * 0.12;
                    Console.WriteLine($"{commission:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Varna")
            {
                if (volume >= 0 && volume <= 500)
                {
                    double commission = volume * 0.045;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (volume > 500 && volume <= 1000)
                {
                    double commission = volume * 0.075;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (volume > 1000 && volume <= 10000)
                {
                    double commission = volume * 0.10;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (volume > 10000)
                {
                    double commission = volume * 0.13;
                    Console.WriteLine($"{commission:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Plovdiv")
            {
                if (volume >= 0 && volume <= 500)
                {
                    double commission = volume * 0.055;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (volume > 500 && volume <= 1000)
                {
                    double commission = volume * 0.08;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (volume > 1000 && volume <= 10000)
                {
                    double commission = volume * 0.12;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (volume > 10000)
                {
                    double commission = volume * 0.145;
                    Console.WriteLine($"{commission:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
