using System;

namespace Nested_Loops___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int currentNum = 1;
                bool flag = false;

            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    if (currentNum > n)
                    {
                        flag = true;
                        break;
                    }
                    Console.Write(currentNum + " ");
                    currentNum++;
                }

                if (flag)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
