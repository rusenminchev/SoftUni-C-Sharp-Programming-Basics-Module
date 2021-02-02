using System;

namespace Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int combCounter = 0;

            for (int i = start; i <= end; i++)
            {

                for (int j = start; j <= end; j++)
                {
                    combCounter++;
                    int sum = i + j;
                    if (sum == magicNum)
                    {
                        Console.WriteLine($"Combination N:{combCounter} ({i} + {j} = {magicNum})");
                        return;
                    }
                }


            }
            
            Console.WriteLine($"{combCounter} combinations - neither equals {magicNum}");

        }
    }
}
