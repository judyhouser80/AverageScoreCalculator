using System;
using System.IO;

namespace AverageScoreCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            //average score calculator
            //make sure program does not crash when something other than a number is added.
            //make sure program does not crash when a number not in range is added.

            double studentScore1, studentScore2, studentScore3, studentScore4;

            Console.WriteLine("Enter first student score:  ");
            studentScore1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second student score:  ");
            studentScore2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter third student score:  ");
            studentScore3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter fourth student score:  ");
            studentScore4 = Convert.ToDouble(Console.ReadLine());

            double result = (studentScore1 + studentScore2 + studentScore3 + studentScore4) / 4;
            Console.WriteLine("The average student score of {0}, {1}, {2}, {3}, is:  {4}", studentScore1, studentScore2, studentScore3, studentScore4, result);
        }
    }
}
