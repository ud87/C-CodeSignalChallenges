/*
 In this task, you are given a string s, and your goal is to produce a new string following 
a specific pattern. You are to take characters in sets of three, reverse the characters in 
each set, and then place them back into the string in their original positions, preserving 
the reverse order within each set. If 1 or 2 characters remain at the end (because the length 
of the string is not divisible by 3), they should be left as they are.

The string s contains only lowercase English letters, with its length ranging from 1 to 300, 
inclusive.

For example, if you are given the input 'abcdef', the output should be 'cbafed'. For the 
input 'abcdefg', your function should provide 'cbafedg'.
 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeCharactersReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution.ReversedTripleChars("udayasadvsa");
            Console.ReadLine();
        }
    }

    public static class Solution
    {
        public static string ReversedTripleChars(string s)
        {
            // TODO: Implement the function that reform the string as described above

            //find the length
            int length = s.Length;
            

            //divide by three to find the total no of set of numbers
            int threeSetNumbers = length / 3;
        

            //Console.WriteLine($"threeSetNumbers: {threeSetNumbers}");

            //used to count the iteration of threeSetNumbers in a loop
            int counter = 0;

            string result = "";

            //loop through numbers that are threeSetNumbers only
            for (int i = 0; i <= threeSetNumbers * 3; i= i + 3)
            {
                //exits the loop if iteration of threeSetnumbers == threeSetNumbers
                if (counter == threeSetNumbers)
                {
                    break;
                }

                //assign value to tempString from start to start + 3
                string tempString = s.Substring(i, 3);
                Console.WriteLine(tempString);

                string reverseTempString = "";
                //reverse tempString and add to reverseTempString
                for (int j = tempString.Length - 1; j >= 0; j--)
                {
                    reverseTempString += tempString[j];
                }

                //Console.WriteLine(reverseTempString);
                result += reverseTempString;
                counter++;
            }

            //If number is not divisible by three 
            if (length > threeSetNumbers * 3)
            {
                for (int i = threeSetNumbers * 3; i < length; i++)
                {
                    result += s[i];
                }
            }


            Console.WriteLine(result);
            return result;
        }
    }
}
