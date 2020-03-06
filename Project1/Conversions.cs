using System;

namespace Project1
{
    class Conversions
    {
        static void Main(string[] args)
        {

            // Where to start?
            // Step1: Make a while loop that exits when the input is 0              - LESSON 6
            // Step2: Make an if statement that is true when the input is 1     - LESSON 4, LESSON 5
            // Step3: Make another if that takes 1
            // Step4: Do the correct conversion                         - LESSON 3

            // TIP: Remember that Console.ReadLine() returns a string
            //      a string "0" IS NOT the same as an Int 0

            //int count = 20;
            int userInput;

            //Console.WriteLine(count + ": ");
            //count = count - 1;
            Console.WriteLine("Would you like to convert:");
            Console.WriteLine("1: Distance");
            Console.WriteLine("2: Temperature");
            Console.WriteLine("3: Weight");
            Console.WriteLine("0: Exit");
            userInput = Convert.ToInt32(Console.ReadLine());

            do
            {



                if (userInput == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Would you like to convert:");
                    Console.WriteLine("1: Distance");
                    Console.WriteLine("2: Temperature");
                    Console.WriteLine("3: Weight");
                    Console.WriteLine("0: Exit");
                    Console.WriteLine("You have selected " + userInput + ": Distance");

                    do
                    {
                        Console.WriteLine("testtets");
                    }
                    while (userInput == 0);
                    {
                        Console.WriteLine("this is the user test");
                    }
                }
                else if (userInput == 2)
                {
                    Console.WriteLine("Temp");
                    do
                    {
                        Console.WriteLine("Test2222");
                    }
                    while (userInput == 1);
                    {
                        Console.WriteLine("this is the user test222");
                    }
                }
                else if (userInput == 3)
                {
                    Console.WriteLine("Weight");
                    do
                    {
                        Console.WriteLine("testtets3333");
                    }
                    while (userInput == 3);
                    {
                        Console.WriteLine("this is the user test3333");
                    }
                }
                else if (userInput == 0)
                {
                    Console.WriteLine("Exiting Program");
                }

            } while (userInput != 0);
        }
    }
}
