using System;

namespace Moving_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            string numberOfBoxes = Console.ReadLine();

            int freeVolume = lenght * hight * width;

            int usedSpace = 0;

            while (numberOfBoxes != "Done")
            {
                usedSpace += int.Parse(numberOfBoxes);
                if (usedSpace >= freeVolume)
                {
                    int diff = Math.Abs(freeVolume - usedSpace);
                    Console.WriteLine($"No more free space! You need {diff} Cubic meters more.");
                    return;
                }
                numberOfBoxes = Console.ReadLine();
            }
            int positiveDiff = Math.Abs(freeVolume - usedSpace);
            Console.WriteLine($"{positiveDiff} Cubic meters left.");
        }
    }
}
