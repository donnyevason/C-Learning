using System;

namespace Lesson6
{
    class WhileLoops
    {
        static void Main(string[] args)
        {
            //if (true)
            //{
            //    Console.WriteLine("The IF is true");
            //}

            //while (true)
            //{
            //    Console.WriteLine("The WHILE is true");
            //}

            //int numberOfLoops = 10;

            //while(numberOfLoops >= 0)
            //{
            //    Console.WriteLine("numberOfLoops = " + numberOfLoops);
            //    numberOfLoops = numberOfLoops - 1;
            //}

            string userInput;

            do
            {
                Console.WriteLine();
                Console.WriteLine("1: Cows go:" );
                Console.WriteLine("2: Cats go: ");
                Console.WriteLine("3: Exit");
                Console.WriteLine("Choose an action: ");

                userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    Console.WriteLine("Moo");
                }

                if (userInput == "2")
                {
                    Console.WriteLine("Meow");
                }


            } while (userInput != "3");




        }
    }
}
