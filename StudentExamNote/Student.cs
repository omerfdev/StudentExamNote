using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace StudentExamNote
{
    internal class Student
    {
        public Student()
        {
            Console.WriteLine("{0:r}", DateTime.Now);
            Console.Write("Please Enter First Exam Note: ");
            StudentExam = double.Parse(Console.ReadLine());
            Console.Write("Please Enter Final Note: ");
            StudentExamFinal = Convert.ToInt32(Console.ReadLine());
            Calculate(); 
        }
        public double StudentExam { get; set; }
        public double StudentExamFinal { get; set; }
        public double StudentPoint { get; set; }
        /// <summary>
        /// The method that takes the average exam
        /// </summary>
        /// <returns></returns>
        public void Calculate()
        {
            StudentPoint = (StudentExam * 0.4 + StudentExamFinal * 0.6);
            if (StudentPoint < 50)
              Console.WriteLine($"You Failed... Your Point:{StudentPoint}");
            else
                Console.WriteLine($"You Passed... Your Point:{StudentPoint}");

        }
    }
}
