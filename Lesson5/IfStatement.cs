using System;

namespace Lesson5
{
    class IfStatement
    {
        static void Main(string[] args)
        {
            //if (true)
            //{
            //    Console.WriteLine("This will always be true");
            //}

            //if (false)
            //{
            //    Console.WriteLine("This will never execute");
            //}

            //Console.Write("Enter x: ");
            //int x = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter y: ");
            //int y = Convert.ToInt32(Console.ReadLine());

            //if ( x > y)
            //{
            //    Console.WriteLine("x is bigger than y.");
            //}
            //else if (y > x)
            //{
            //    Console.WriteLine("y is bigger than x");
            //}
            //else
            //{
            //    Console.WriteLine("X is Equal to Y");
            //}

            //if ( x > y)
            //{
            //    Console.WriteLine("x is bigger than y");
            //}

            //if ( y > x)
            //{
            //    Console.WriteLine("y is bigger than x");
            //}

            //if(x == y)
            //{
            //    Console.WriteLine("x is equal to y");
            //}

            Console.WriteLine("What planet are we on?");
            string planetAnswer = Console.ReadLine();

            if (planetAnswer == "Earth")
            {
                Console.WriteLine("Earth is correct!");
            }
            else
            {
                Console.WriteLine(planetAnswer + " is wrong!");
            }

            Console.WriteLine("How many sides are on a cube?");
            int sideAnswer = Convert.ToInt32(Console.ReadLine());

            if (sideAnswer != 6)
            {
                Console.WriteLine(sideAnswer + " is wrong");
            }
            else
            {
                Console.WriteLine("6 is correct!");
            }

            Console.WriteLine("Input a number greater than 9.0");
            double nineAnswer = Convert.ToDouble(Console.ReadLine());
            bool isCorrect = nineAnswer > 9.0;

            if (isCorrect)
            {
                Console.WriteLine(nineAnswer + " is correct");
            }
            else
            {
                Console.Write(nineAnswer + " that is wrong!");
            }
        }
    }
}
