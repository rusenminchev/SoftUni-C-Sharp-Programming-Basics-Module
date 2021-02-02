using System;

namespace Loops___Excersices
{
    class Program
    {
        static void Main(string[] args)
        {
            string wantedBook = Console.ReadLine();
            int libraryCapacity = int.Parse(Console.ReadLine());

            int checkedBooks = 0;

            while (libraryCapacity > 0) 
            {
                string currentBook = Console.ReadLine();
                libraryCapacity--;

                    if (currentBook == wantedBook)
                    {
                        Console.WriteLine($"You checked {checkedBooks} books and found it.");
                        return;
                    }
                    checkedBooks++;             
            }

            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {checkedBooks} books.");
        }
    }
}
