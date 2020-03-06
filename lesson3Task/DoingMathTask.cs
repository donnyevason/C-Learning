/*
* TASK:
* Create a program that calculates an employees' pay.
* Ask for their Employee ID. This value will always be an INT.
* Ask for the number of hours they worked.
* Ask for their hourly pay rate.
* 
* Example Output
*      Enter employee ID: 1154856
*      Enter hours worked: 16.55
*      Enter hourly pay: 12.77
*      Employee 1154856, you have earned $211.34‬
* 
*/

using System;

namespace Lesson3Task
{
    class DoingMathTask
    {
        static void Main(string[] args)
        {
            //NOTE: You will need to use convert.

            //Step 1: Ask for the employee ID. Store the input from the user into an int variable.

            Console.WriteLine("Enter your ID number: ");
            int ID = Convert.ToInt32(Console.ReadLine());

            //Step 2: Ask for the number of hours they worked.
            Console.WriteLine("How many hours have you worked this week: ");
            double Hours = Convert.ToDouble(Console.ReadLine());

            //Step 3: Ask for their hourly pay.

            Console.WriteLine("Enter your hourly wage: ");
            double Wage = Convert.ToDouble(Console.ReadLine());

            //Step 4: Multiply hours by pay.

            Console.WriteLine("Hours * Pay: = " + (Hours * Wage));

            //Step 5: Round the result to 2 decimal places.
            double result = Hours * Wage;
            double rounded = Math.Round(result, 1);

            //Step 6: Display the result to the user.
            Console.WriteLine("Employee " + ID + ", You have earned: " + rounded);

        }
    }
}
