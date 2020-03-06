/*
* TASK:
*   Make a while loop that prints 10-20.
*   Print '**********' to the console.
*   Make a while loop that prints all the even numbers from 2 - 20
*   Print '**********' to the console.
*   Make a while loop that prints the powers of 2 from 1 - 256
*   
*   Example output:
*       10
*       11
*       12
*       13
*       14
*       15
*       16
*       17
*       18
*       19
*       20
*       **********
*       2
*       4
*       6
*       8
*       10
*       12
*       14
*       16
*       18
*       20
*       **********
*       1
*       2
*       4
*       8
*       16
*       32
*       64
*       128
*       256
*   
*   BONUS POINTS:
*   Research how to use Console.Write() and use it to print the output on a single line each
*   with spaces between the numbers.
*   
*   Example Output:
*       10 11 12 13 14 15 16 17 18 19 20
*       **********
*       2 4 6 8 10 12 14 16 18 20
*       **********
*       1 2 4 8 16 32 64 128 256
* 
*/


using System;

namespace Lesson6Task
{
    class WhileTask
    {
        static void Main(string[] args)
        {
            int count1 = 10;

            while(count1 <= 20)
            {
                Console.Write(count1 + " " );
                count1 = count1 + 1;
            }

            Console.WriteLine();
            Console.WriteLine("**********");

            int count2 = 2;
            while (count2 <= 20)
            {
                Console.Write(count2 + " ");
                count2 = count2 + 2;
            }

            Console.WriteLine();
            Console.WriteLine("**********");

            int count3 = 0;
            while (count3 < 9)
            {
                Console.Write(Math.Pow(2, count3) + " ");
                count3 = count3 + 1;
            }

        }
    }
}

