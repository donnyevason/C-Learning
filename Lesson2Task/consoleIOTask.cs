/*
* TASK:
* Create a program that fills out a mad lib with data supplied by the user.
* (Hint: a Verb is an action. A noun is a person/place/thing.
* An adjective describes a person/place/thing.)
* 
* NOTE: Be sure that you have proper spaceing between words.
* 
* Example Output:
*   Enter Occupation(a job): Gardener
*   Enter Noun1: Bird
*   Enter Adjective1: Blue
*   Enter Noun2: Hat
*   Enter Verb1: Fight
*   Enter Adjective2: Happy
*   Enter Noun3: Boots
*   Enter Verb2: Run
*   Enter Noun4: Gloves
*   Enter Verb3: Fall
*   
*   Today a <Occupation> named <Noun4> came to our school to talk to us about her job.
*   She said the most important skill you need to know to do her job is to be able
*   to <Verb2> around (a) <Adjective1> <Noun3>.
*   She said it was easy for her to learn her job because she loved to <Verb1> when she was my age--
*   and that helps a lot! If you're considering her profession,
*   I hope you can be near (a) <Adjective2> <Noun1>. That's very important!
*   If you get too distracted in that situation you won't be able to <Verb3> next to (a) <Noun2>!
*   
*********************
* Credit to Steve Hanson https://www.glowwordbooks.com/blog/2016/04/19/online-kids-mad-libs-about-jobs/
* 
*/

using System;

namespace Lesson2Task
{
    class ConsoleIOTask
    {
        static void Main(string[] args)
        {
            //You will need to make 10 string variables.    ex: string occupation;
            //Then prompt the user to enter a word.         ex: Console.WriteLine("Enter Occupation(a job): ");
            //Set the variable equal to the user's input.   ex: occupation = Console.ReadLine();
            //Finally, after you have all 10 words.
            //You can print the madlib                      ex: Console.WriteLiine("Today a " + occupation + " named");

            Console.WriteLine("What is your occupation?");
            string myOcc;
            myOcc = Console.ReadLine();

            Console.WriteLine("Enter a noun");
            string Noun1;
            Noun1 = Console.ReadLine();

            Console.WriteLine("Enter an adjective");
            string adjective1;
            adjective1 = Console.ReadLine();

            Console.WriteLine("Enter another noun");
            string noun2;
            noun2 = Console.ReadLine();

            Console.WriteLine("Enter a verb");
            string verb1;
            verb1 = Console.ReadLine();

            Console.WriteLine("Enter another adjective");
            string adjective2;
            adjective2 = Console.ReadLine();

            Console.WriteLine("Enter another noun");
            string noun3;
            noun3 = Console.ReadLine();

            Console.WriteLine("Enter another verb");
            string verb2;
            verb2 = Console.ReadLine();

            Console.WriteLine("Enter anohter noun");
            string noun4;
            noun4 = Console.ReadLine();

            Console.WriteLine("Enter a final verb");
            string verb4;
            verb4 = Console.ReadLine();

            Console.WriteLine("Today a " + myOcc + " named " + noun4 + " came to our school to talk to us about their job." +
                " She said the most important skill you need to know to do her job is to be able to " + verb2 + " around " + adjective1 + noun3 +
                " She said it was easy for her to learn her job becasue she to loved " + verb1 + " when she was my age -- and that helps a lot!" +
                " If you are considering her profession, I hope you can be near a " + adjective2 + Noun1 + " That's very important! " +
                " If you get too distracted in that situation you won't be ablt to " + verb2 + " next to a " + noun2!);

        }
    }
}
