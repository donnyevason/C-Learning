using System;

namespace Lesson3
{
    class Lesson3
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter an Int!: ");
            //int x = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter another Int!: ");
            //int y = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("X: " + x + ", y: " + y);

            //Console.WriteLine("X * y = " + x * y );
            //Console.WriteLine("X + Y = " + (x + y)); //(if X = 4 and y = 2 this will concatonate to give 42 | "X + Y + X" then adds Y to the end (4 + 2 + 2)
            //So we add " ( ) " to do addition first

            //Console.WriteLine("x / y = " + (x / y));
            //Console.WriteLine("y / x - " + (y / (double) x));

            Console.Write("Enter a Double:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another Double: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("a: " + a + ", b: " + b);

            Console.WriteLine(" a / b = " + (a / b));
            Console.WriteLine(" a + b = " + (a + b));

            double addResult = a + b;
            double roundedResult = Math.Round(addResult, 1);
            Console.WriteLine("Rounded: a + b = " + roundedResult);
        }
    }
}
