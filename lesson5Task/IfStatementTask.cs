using System;

namespace lesson5Task
{
    class IfStatementTask
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many sides to a square?\t");
            int answer1 = Convert.ToInt32(Console.ReadLine());
            int correct = 0;
            int incorrect = 0;

            if (answer1 != 4)
            {
                Console.Write(answer1 + " is incorrect!\t");
                incorrect = incorrect + 1;

            }
            else
            {
                Console.Write(answer1 + " Is correct!\t");
                correct = correct + 1;
            }

            Console.WriteLine("Enter a number greater than 17!\t");
            double answer2 = Convert.ToDouble(Console.ReadLine());

            if(answer2 > 17)
            {
                Console.WriteLine("Correct!" + answer2 + " is a greater value!\t");
                correct = correct + 1;
            }
            else
            {
                Console.WriteLine("Incorrect!" + answer2 + " is a lesser value!\t");
                incorrect = incorrect + 1;
            }
            Console.WriteLine("Is the sun yellow?!\t");
            string answer3 = Console.ReadLine();

            if (answer3 == "yes")
            {
                Console.WriteLine("Correct!" + answer3 + " the sun is yellow!\t");
                correct = correct + 1;
            }
            else
            {
                Console.WriteLine("Incorrect!" + answer3 + " is not the colour of the sun!\t");
                incorrect = incorrect + 1;
            }

            Console.WriteLine("You got " + correct + " questions correct!");
            Console.WriteLine("You got " + incorrect + " questions incorrect!");
        }
    }
}

