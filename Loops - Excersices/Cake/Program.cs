using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int cakeArea = width * lenght;

            string cakePieces = Console.ReadLine();
            int cakePiecesSum = 0;

            while (cakePieces != "STOP")
            {

                cakePiecesSum += int.Parse(cakePieces);
                
                if (cakePiecesSum >= cakeArea)
                {
                    int notEnough = cakePiecesSum - cakeArea;

                    Console.WriteLine($"No more cake left! You need {notEnough} pieces more.");
                    return;
                }
                cakePieces = Console.ReadLine();
            }

            int piecesLeft = cakeArea - cakePiecesSum;

            Console.WriteLine($"{piecesLeft} pieces are left.");

        }
    }
}
