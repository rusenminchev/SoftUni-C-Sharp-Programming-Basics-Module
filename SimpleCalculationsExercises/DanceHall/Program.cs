using System;

namespace DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());

            double hallArea = (100 * l) * (100 * w);
            double bench = hallArea / 10;
            double wardrobeArea = (100 * a) * (100 * a);
            double freeSpace = hallArea - bench - wardrobeArea;
            Console.WriteLine(Math.Round(freeSpace / 7040));
        }
    }
}
