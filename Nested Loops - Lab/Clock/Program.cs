﻿using System;

namespace Nested_Loops___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hours = 0; hours <= 23; hours++)
            {
                for (int minutes = 0; minutes <= 59; minutes++)
                {
                    Console.WriteLine($"{hours}:{minutes}");
                }

            }
        }
    }
}
