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
            string choice1 = "Distance";
            string choice2 = "Temperature";
            string choice3 = "Weight";
            string choice0 = "Exit";
            string distance1 = "KM to Miles";
            string distance2 = "Miles to KM";


            do
            {
                Console.WriteLine();
                Console.WriteLine("Would you like to convert:");
                Console.WriteLine("1: Distance");
                Console.WriteLine("2: Temperature");
                Console.WriteLine("3: Weight");
                Console.WriteLine("0: Exit");
                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == 1)
                {
                    Console.WriteLine("You have selected " + userInput + ": " + choice1 + "\n");
                    Console.WriteLine("How would you like to convert either of the following: \n");
                    Console.WriteLine("1: KM to Miles");
                    Console.WriteLine("2: Miles to KM");
                    Console.WriteLine("0: Exit");
                    userInput = Convert.ToInt32(Console.ReadLine());

                    if (userInput == 1)
                    {
                        Console.WriteLine("You have selected: " + userInput + ": " + distance1 + "\n");

                        if(userInput == 1)
                        {
                            Console.WriteLine("please enter an amount to conver\n");
                            double a = Convert.ToDouble(Console.ReadLine());
                            double b = 0.62137;
                            Console.WriteLine(a + "KM to 1 Mile " + "is " + (a * b));
                            break;
                        }
                    }
                    else if (userInput == 2)
                    {
                        Console.WriteLine("You have selected " + userInput + distance2);
                        if (userInput == 2)
                        {
                            Console.WriteLine("please enter an amount to conver\n");
                            double a = Convert.ToDouble(Console.ReadLine());
                            double b = 0.62137;
                            Console.WriteLine(a + "Miles to KM " + "is " + (a / b));
                            break;
                        }
                    }
                    else if (userInput == 0)
                    {
                        Console.WriteLine("" + choice0);
                    }
                    while (userInput != 0);
                }
               
                else if (userInput == 2)
                {
                    Console.WriteLine("You have selected " + userInput + choice2);
                    Console.WriteLine("Would you like to convert either of the following: \n");
                    Console.WriteLine("1: Celsius to Fahrenheit");
                    Console.WriteLine("2: Fahrenheit to Celsius");
                    Console.WriteLine("0: Exit");
                }

                else if (userInput == 3)
                {
                    Console.WriteLine("You have selected " + userInput + choice3);
                    Console.WriteLine("Would you like to convert either of the following: ");
                    Console.WriteLine("1: Kilogram to Pound");
                    Console.WriteLine("2: Pound to Kilogram");

                }
                else if (userInput == 0)
                {
                    Console.WriteLine("You have selected " + userInput + choice0);
                }

            } while (userInput != 0);
        }
    }
}
