using System;

namespace _07._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();


            if (figure == "square")
            {
                double sideA = double.Parse(Console.ReadLine());
                Console.WriteLine($"{sideA * sideA:f3}");

            }

            if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
               double sideB = double.Parse(Console.ReadLine());
                Console.WriteLine($"{sideA * sideB:f3}");
            }

            if (figure == "circle")
            {
                double sideA = double.Parse(Console.ReadLine());
                Console.WriteLine($"{3.14159 * sideA * sideA:f3}");

            }

            if (figure == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                Console.WriteLine($"{sideA * sideB / 2:f3}");
            }
        }
    }
}
