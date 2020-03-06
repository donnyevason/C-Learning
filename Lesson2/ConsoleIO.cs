using System;

namespace Lesson2
{
    class ConsoleIO
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string myName;
            myName = Console.ReadLine();

            Console.WriteLine("What is your age?");
            int myAge;
            myAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name is " + myName + " and your age is " + myAge);

            Console.WriteLine("What is the decimal value of 1/10?");
            double answer;
            answer = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("I hope " + answer + " is right");

        }
    }
}
