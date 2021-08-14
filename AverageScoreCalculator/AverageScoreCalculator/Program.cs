using System;
using System.IO;

namespace AverageScoreCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            //average score calculator using for loop 
            //make sure program does not crash when something other than a number is added.
            //make sure program does not crash when a number not in range is added.

            string input = "0";
            int count = 0;
            int total = 0;
            int currentNumber = 0; 

            while(input != "-1")
            {
                Console.WriteLine("Last number was {0}", currentNumber);
                Console.WriteLine("Please enter the next score.");
                Console.WriteLine("Current amount of entries {0}", count);
                Console.WriteLine("Please enter -1 once you are ready to calculate the average");

                input = Console.ReadLine();
                if(input == "-1")
                {
                    Console.WriteLine("---------");
                    
                    //Calculate average.
                }

                if(int.TryParse(input, out currentNumber) && currentNumber > 0 && currentNumber < 101)
                {
                    total = total + currentNumber;
                }
                else
                {
                    if(!(input.Equals("-1")))
                    {
                        Console.WriteLine("Please enter a value between 1 and 100.");
                    }
                    continue;
                }
            }    

            /*double studentScore1, studentScore2, studentScore3, studentScore4;

            Console.WriteLine("Enter first student score:  ");
            studentScore1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second student score:  ");
            studentScore2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter third student score:  ");
            studentScore3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter fourth student score:  ");
            studentScore4 = Convert.ToDouble(Console.ReadLine());

            double result = (studentScore1 + studentScore2 + studentScore3 + studentScore4) / 4;
            Console.WriteLine("The average student score of {0}, {1}, {2}, {3}, is:  {4}", studentScore1, studentScore2, studentScore3, studentScore4, result); */
        }
    }
}
