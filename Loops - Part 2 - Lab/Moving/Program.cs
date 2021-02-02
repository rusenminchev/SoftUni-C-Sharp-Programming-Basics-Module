using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            int numberOfBoxes = int.Parse(Console.ReadLine());

            int freeVolume = lenght * hight * width;
            int usedSpace = numberOfBoxes * 1;

            string command = "";

            while (freeVolume >= usedSpace)
            {
                numberOfBoxes = int.Parse(Console.ReadLine());
                usedSpace += numberOfBoxes;
                

            }
            int diff = Math.Abs(freeVolume - usedSpace);
            Console.WriteLine($"No more free space! You need {diff} Cubic meters more.");
        }
    }
}
