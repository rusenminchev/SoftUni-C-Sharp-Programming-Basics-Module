using System;

namespace Cake2
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int cakeArea = width * lenght;

            string cakePieces = "";
            int cakePiecesSum = 0;

            while (cakePiecesSum < cakeArea)
            {

                cakePieces = Console.ReadLine();
                if (cakePieces != "STOP")
                {

                    int piecesLeft = Math.Abs(cakePiecesSum - cakeArea);
                    Console.WriteLine($"{piecesLeft} pieces are left.");
                    return;
                }
                cakePiecesSum += int.Parse(cakePieces);    
            }

            int notEnough = Math.Abs(cakePiecesSum - cakeArea);
            Console.WriteLine($"No more cake left! You need {notEnough} pieces more");
            
        }
    }
}
