using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace codingchallenge
{
    class Program
    {
        static void Main(string[] args)

        //NOTE: I overall referred myself to https://www.w3schools.com/cs/default.asp when I don't get the syntax right
        {
            for (int i = 1; i <= 100; i++) // will use a for loop to iterate through the integer list, I'll start at 1, hence the value of i is 1. The condition is that i needs to be less than or equal to 100 in order to stop it there. Then I'll be adding 1 to the value of i to go to the next number.
            {
                if (i % 3 == 0) // then I'll throw some if statements inside the loop. In this case it is to test for the multiples of 3.
                {               // I watch a tutorial on youtube on how to get the multiples as I wasn't sure -> https://www.youtube.com/watch?v=3UIb-Snktss
                    Console.WriteLine("sweet"); // console will print sweet for multiples of 3
                }
                if (i % 5 == 0) // another if statement to get the multiples of 5
                {
                    Console.WriteLine("salty"); // it'll print salty for the multiples of 5
                }
                if (i % 3 == 0 && i % 5 == 0) // one last if statement to set the condition for those numbers who are BOTH multiples of three AND five
                {
                    Console.WriteLine("sweet’nSalty"); // it'll print sweet'nSalty for these ones
                }
                else if (i % 3 != 0 && i % 5 != 0) // lastly an else if statement for those numbers that don't comply with the three above listed conditions
                {
                    Console.WriteLine(i); // only the number value will be printed
                }

                List<string> results = new List<string>(); // maybe I could use a list to store the output in it

                results.Add(Convert.ToString(i)); // to add results into list converting them into string type

                // thought about querying the results list to count the sweet's, salty's and sweet'nSalty's

                //data source: results

                // define query expression

                // IEnumerable<string> results;
                //string count = (from result in results where result = "sweet" select result).Count(); // found this syntax at https://www.csharp-examples.net/linq-count/

                // couldn't get query to run
            }
        }
    }
}
