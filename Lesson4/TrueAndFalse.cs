using System;

namespace Lesson4
{
    class TrueAndFalse
    {
        static void Main(string[] args)
        {
            bool trueValue = true;
            Console.WriteLine("This is a true value:\t" + trueValue);

            bool falseValue = false;
            Console.WriteLine("This is a false value:\t" + falseValue);

            /* Comparison Operators
             *  ==, Is Equal To
             * !=, Is Not Equal TO
             * >, greater than
             * <. less than
             * >=, greater than or equal to
             * <=, less than or equal to
             */

            bool value1 = 7 == 7;
            Console.WriteLine("7 IS EQUAL TO 7:\t" + value1);

            bool value2 = 7 != 7;
            Console.WriteLine("7 IS NOT EQUAL TO 7:\t" + value2);

            bool value3 = 99 > 1;
            Console.WriteLine("99 IS GREATER THAN 1:\t" + value3);

            bool value4 = 99 < 1;
            Console.WriteLine("99 IS LESS THAN 1:\t" + value4);

            bool value5 = 2 >= 1;
            Console.WriteLine("2 IS GREATER THAN OR EQUAL TO 1:\t" + value5);

            bool value6 = 2 <= 2;
            Console.WriteLine("2 IS LESS THAN OR EQUAL TO 2:\t" + value6);

            bool value7 = "cup" == "CUP";
            Console.WriteLine("cup IS EQUAL TO CUP:\t" + value7);



        }
    }
}
