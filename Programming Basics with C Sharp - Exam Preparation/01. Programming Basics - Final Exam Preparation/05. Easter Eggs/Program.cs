using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace _05._Easter_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfEggs = int.Parse(Console.ReadLine());

            int counterRed = 0;
            int counterOrange = 0;
            int counterBlue = 0;
            int counterGreen = 0;

            int max = int.MinValue;

            for (int i = 1; i <= numOfEggs; i++)
            {
                string color = Console.ReadLine();



                if (color == "red")
                {
                    counterRed++;
                }
                else if (color == "orange")
                {
                    counterOrange++;
                }
                else if (color == "blue")
                {
                    counterBlue++;
                }
                else if (color == "green")
                {
                    counterGreen++;
                }

            }

            string colorMax = "";

            if (counterRed > max)
            {
                max = counterRed;
                 colorMax = "red";
            }
            if (counterOrange > max)
            {
                max = counterOrange;
                 colorMax = "orange";
            }
            if (counterBlue > max)
            {
                max = counterBlue;
                 colorMax = "blue";
            }
            if (counterGreen > max)
            {
                max = counterGreen;
                 colorMax = "green";
            }
            
            Console.WriteLine($"Red eggs: {counterRed}");
            Console.WriteLine($"Orange eggs: {counterOrange}");
            Console.WriteLine($"Blue eggs: {counterBlue}");
            Console.WriteLine($"Green eggs: {counterGreen}");
            Console.WriteLine($"Max eggs: {max} -> {colorMax}");
            
        }
    }
}
