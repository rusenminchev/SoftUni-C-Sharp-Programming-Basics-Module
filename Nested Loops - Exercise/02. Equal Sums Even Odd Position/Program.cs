﻿using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;

            for (int i = num1; i <= num2; i++)
            {

                string currentNum = i.ToString();

                for (int j = 0; j < currentNum.Length; j++)
                {
                    int currentDigit = int.Parse(currentNum.ToString());

                    if (j % 2 == 0)
                    {
                        evenSum += currentDigit;
                    }
                    else
                    {
                        oddSum += currentDigit;
                    }
                    
                }
                if (evenSum == oddSum)
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}
