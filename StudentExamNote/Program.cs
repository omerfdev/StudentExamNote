using System;

namespace StudentExamNote
{
    class Program
    {
        static void Main(string[] args)
        {
            int exam1, final, ava;
            Console.Write("Please Enter First Exam Note: ");
            exam1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Final notunu giriniz: ");
            final = Convert.ToInt32(Console.ReadLine());
            ava = Convert.ToInt32(exam1 * 0.4 + final * 0.6);
            Console.WriteLine();
            Console.WriteLine("Ortalamanız = {0}", ava);
            Console.WriteLine();
            if (ava < 50 || final < 50)
                Console.WriteLine("You Fail.");
            else
                Console.WriteLine("You Passed.");

            Console.ReadKey();
        }
    }
}
