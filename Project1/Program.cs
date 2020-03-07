using System;

namespace Project1
{
    class Conversions
    {
        static void Main(string[] args)
        {
            int userInput;
            string choice1 = "Distance";
            string choice2 = "Temperature";
            string choice3 = "Weight";
            string choice0 = "Exiting program";
            string distance1 = "Kilometeres";
            string distance2 = "Miles";
            string temp1 = "Celsius";
            string temp2 = "Fahrenheit";
            string weight1 = "Kilograms";
            string weight2 = "Pounds";


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
                    Console.WriteLine("1: Kilometers to Miles");
                    Console.WriteLine("2: Miles to Kilometers");
                    Console.WriteLine("0: Exit");
                    userInput = Convert.ToInt32(Console.ReadLine());

                    if (userInput == 1)
                    {
                        Console.WriteLine("You have selected: " + userInput + ": " + distance1 + " to " + distance2 + " \n");

                        if (userInput == 1)
                        {
                            Console.WriteLine("please enter an amount to convert\n");
                            double dis1 = Convert.ToDouble(Console.ReadLine());
                            double dis2 = 0.62137;
                            Console.WriteLine(dis1 + "KM to Miles " + "is " + (dis1 * dis2));
                            break;
                        }
                    }
                    else if (userInput == 2)
                    {
                        Console.WriteLine("You have selected " + userInput + ": " + distance2 + " to "  + distance1 + "\n");
                        if (userInput == 2)
                        {
                            Console.WriteLine("please enter an amount to convert\n");
                            double dis1 = Convert.ToDouble(Console.ReadLine());
                            double dis2 = 0.62137;
                            Console.WriteLine(dis1 + "Miles to KM " + "is " + (dis1 / dis2));
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
                    Console.WriteLine("You have selected " + userInput + ": " + choice2 + "\n");
                    Console.WriteLine("How would you like to convert either of the following: \n");
                    Console.WriteLine("1: Celsius to Fahrenheit");
                    Console.WriteLine("2: Fahrenheit to Celsius");
                    Console.WriteLine("0: Exit");
                    userInput = Convert.ToInt32(Console.ReadLine()); 

                    if(userInput == 1)
                    {
                        Console.WriteLine("You have selected " + userInput + ": " + temp1 + " to" + temp2);
                        Console.WriteLine("Enter an amount to convert\n");
                        double tempInput1 = Convert.ToDouble(Console.ReadLine());
                        double tempInput2 = (tempInput1 * 9/5) + 32;
                        Console.WriteLine(tempInput1 + " " + temp1 + " to " + temp2 + " is " + tempInput2 + " " + temp2);
                        break;


                    }
                    else if (userInput == 2)
                    {
                        Console.WriteLine("You have selected " + userInput + ": " + temp2 + " to" + temp1);
                        Console.WriteLine("Please enter an amount to convert\n");
                        double tempInput1 = Convert.ToDouble(Console.ReadLine());
                        double tempInput2 = (tempInput1 - 32) * 5/9;
                        Console.WriteLine(tempInput1 + " " + temp2 + " to " + temp1 + " is " + tempInput2 + " " + temp1);
                        break;
                    }
                }

                else if (userInput == 3)
                {
                    Console.WriteLine("You have selected " + userInput + ": " + choice3 + "\n");
                    Console.WriteLine("How would you like to convert either of the following: \n");
                    Console.WriteLine("1: Kilogram to Pound");
                    Console.WriteLine("2: Pound to Kilogram"); 
                    Console.WriteLine("0: Exit");
                    userInput = Convert.ToInt32(Console.ReadLine());

                    if (userInput == 1)
                    {
                        Console.WriteLine("You have selected: " + userInput + ": Convert: " + weight1 + " to " + weight2 + " \n");
                        Console.WriteLine("Please enter an ammount to convert:");
                        double weightInput1 = Convert.ToDouble(Console.ReadLine());
                        double weightInput2 = weightInput1 * 2.2046;
                        double roundedRes = Math.Round(weightInput2);
                        Console.WriteLine(weightInput1 + " " + weight1 + " to " + weight2 + " is " + roundedRes + " " +  weight2);
                        break;
                    }
                    else if (userInput == 2 )
                    {
                        Console.WriteLine("You have selected: " + userInput + ": Convert: " + weight2 + " to " + weight1 + " \n");
                        Console.WriteLine("Please enter an ammount to convert:");
                        double weightInput1 = Convert.ToDouble(Console.ReadLine());
                        double weightInput2 = weightInput1 / 2.2046;
                        double roundedRes = Math.Round(weightInput2);
                        Console.WriteLine(weightInput1 + " " + weight2 + " to " + weight1 + " is " + roundedRes + " " + weight1);
                        break;
                    }
                }           
                else if (userInput == 0)
                {
                    Console.WriteLine("You have selected " + userInput + choice0);
                }

            } while (userInput != 0);
        }
    }
}
