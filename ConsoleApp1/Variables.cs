using System;

namespace ConsoleApp1
{
    class Variables
    {
        static void Main(string[] args)
        {
            string myString;
            myString = "This is a string";

            Console.Write(myString);

            string mySecondString;
            mySecondString = "1000";

            int myInt;
            myInt = 1000;

            int mySecondInt = 2;
            Console.WriteLine("My secont string: " + mySecondString + "!!!!" + myString);
            Console.WriteLine("My int: " + myInt);
            Console.WriteLine("My Second Int: " + mySecondInt);

            double myDouble = 2.12;
            Console.WriteLine("My Double: " + myDouble);
            Console.WriteLine("Goodbye");
        }
    }
}
