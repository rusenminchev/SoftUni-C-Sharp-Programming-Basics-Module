using System;

namespace _03._Exam_Categories
{
    class Program
    {
        static void Main(string[] args)
        {
            int difficulty = int.Parse(Console.ReadLine());
            int complexity = int.Parse(Console.ReadLine());
            int pages = int.Parse(Console.ReadLine());

            string typeOfExam = "";

            if (difficulty >= 80 && complexity >= 80 && pages >= 8)
            {
                typeOfExam = "Legacy";
            }
            else if (difficulty >= 80 && complexity <= 10 && pages >= 1 && pages <= 10)
            {
                typeOfExam = "Master";
            }
            else if (difficulty >= 1 && difficulty <= 100 && complexity >= 50 && pages >= 2)
            {
                typeOfExam = "Hard";
            }
            else if (difficulty >= 1 && difficulty <= 100 && complexity >= 1 && complexity <= 100 && pages >= 1 && pages <= 10)
            {
                typeOfExam = "Regular";
            }
            else if (difficulty <= 30 && complexity >= 1 && complexity <= 100 && pages <= 1)
            {
                typeOfExam = "Easy";
            }
            else if (difficulty <= 10 && complexity >= 1 && complexity <= 100 && pages >= 1 && pages <= 10)
            {
                typeOfExam = "Elementary";
            }
            Console.WriteLine(typeOfExam);
        }
    }
}
