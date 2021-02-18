using System;

namespace StudentExamNote
{
    class Program
    {
        static void Main(string[] args)
        {
            int exam1, final, average;
            Console.Write("Please Enter First Exam Note: ");
            exam1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please Enter Final Note: ");
            final = Convert.ToInt32(Console.ReadLine());
            average = Convert.ToInt32(exam1 * 0.4 + final * 0.6);
            Console.WriteLine();
            Console.WriteLine("Average = {0}", average);
            Console.WriteLine();
            if (average < 50 || final < 50)
                Console.WriteLine("You Fail.");
            else
                Console.WriteLine("You Passed.");

            Console.ReadKey();
        }
    }
}
