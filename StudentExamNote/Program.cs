using System;

namespace StudentExamNote
{
    class Program
    {
        static void Main(string[] args)
        {

            double average=PointCalculate();
            average= Math.Round(average); 

            Console.WriteLine("Average = {0}", average);
            if (average < 50 )
                Console.WriteLine("You Failed");
            else
                Console.WriteLine("You Passed.");

            Console.ReadKey();
        }

        private static double PointCalculate()
        {
            Console.WriteLine("\t" + "{0:r}", DateTime.Now);
            double firstExam = 0; double final = 0; double average = 0;

            try
            {
                Console.Write("Please Enter First Exam Note: ");
                firstExam = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please Enter Final Note: ");
                final = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.Clear();
                PointCalculate();
                Console.WriteLine("Wrong Format Type" + ex.Message);
            }
            finally { average = (firstExam * 0.4) + (final * 0.6); }
                return average; 

        }

    }
}
