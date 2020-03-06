/*
* TASK:
* 
* In this program you will need to make the following variables with the given data types:
*   myName      -   Holds a string value
*   myAge       -   Holds an int value
*   someDecimal -   Holds a decimal value between 0 and 1 ex: .223
*   
* Use string concatination and Console.WriteLine to print:
*   Hello, My name is 
*   I am 
*   A number between 0 and 1 is 
*   
* Where the variable contents are displayed between the <>
*/


// This lets us use Console.WriteLine in our program.
using System;

// We will learn about namespaces in a different lesson.
namespace Lesson1
{
    // We will learn about classes in a different lesson.
    class VariablesTask
    {

        // For now, just know that this is the entry point to our program.
        // The code between the {} is the first section of code that will run.
        static void Main(string[] args)
        {
            // This is a single line comment. It has no effect on the program.
            // It is used to write notes about what the code is doing.
            // ↓↓ Write a comment with your name and today's date under this line ↓↓


            /*
               This is a block comment.
               It can be used for multi lined comments.

               Make a NEW Block comment under this line 
               with your name and today's date on seperate lines

               ↓    ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓
             */

            /* 
             Donny Evason
             28/02/202
             */



            string introText = "Variables!"; 
            Console.WriteLine("Today I'm going to learn " + introText);

            string myName;
            myName = "Donny";
            Console.WriteLine("Hello, My Name is " + myName);

            //Make a variable named myAge with the int data type.
            //Set the variable equal to your age.
            //Display the text 'I am '
            int myAge;
            myAge = 30;
            Console.WriteLine("I am " + myAge + " years old");

            //Make a variable named someDecimal with the decimal data type.
            //Set the variable equal to a number between 0 and 1. ex: .223
            //Display the text 'A number btween 0 and 1 is '

            double someDecimal;
            someDecimal = 0.223;
            Console.WriteLine("A number between 0 and 1 is: " + someDecimal);

        } // This curly brace ends Main 
    } // This curly brace ends VariablesTask
} // This curly brace ends Lesson1Task