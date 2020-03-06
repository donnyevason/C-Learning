
/*
* TASK:
* Below, you will see comparison statements written in english being displayed by Console.WriteLine.
* Make a bool variable that executes the comparison described in the Console.WriteLine.
* Then concatinate the bool to the end of the string.
*/

using System;

namespace Lesson4Task
{
    class TrueAndFalseTask
    {
        static void Main(string[] args)
        {
            bool value1 = 7 > 9;
            Console.WriteLine("7 is greater than 9: " + value1);

            bool value2 = 12 > 15;
            Console.WriteLine("12 is less than 15: " + value2);

            bool value3 = 91 >= 19;
            Console.WriteLine("91 is greater than or equal to 19: " + value3);

            bool value4 = 1.2 != 6.6;
            Console.WriteLine("1.2 is not equal to 6.6: " + value4);

            bool value5 = 17.9 <= 17.91;
            Console.WriteLine("17.9 is less than or equal to 17.91: " + value5);

            bool value6 = 7.5 > 7.4;
            Console.WriteLine("7.5 is greater than 7.4: " + value6);

            bool value7 = "ball" == "BALL";
            Console.WriteLine("ball equals BALL: " + value7);

            bool value8 = "cup" == "cup";
            Console.WriteLine("cup equals cup: " + value8);

            bool value9 = "pan" != "Pan";
            Console.WriteLine("pan is not equal to Pan: " + value9);
        }
    }
}
