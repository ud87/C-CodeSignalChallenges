/*
 Your function should return a string representing all the repeating
character pairs and the number of their repetitions. For instance, if
the input string is "aaabbabbababaca", your function should output: 
"aa1ab1ba1bb1ab2ac1a1". Note that if the length of the input string 
is odd, the last character is not paired with any other and is just 
added to the resulting string with repetition count 1.

Unlike in the lesson, the input strings for this task are guaranteed
to consist only of lowercase alphabetic characters. The length of 
the string will not exceed 500 characters.
 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentifyingConsecutivePairsOfCharactersInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            GetConsecutivePairs("aaabbabbababaca");
            Console.ReadLine();
        }

        public static string GetConsecutivePairs(string s)
        {
            // TODO: Implement the function here
            string pair = s.Substring(0, 2); //get the first pair
            int count = 1;    //set the initial pair count to 1
            string result = "";

            string nextPair = "";

            //loop through string start from index 2 because 0 and 1 is first pair
            for (int i=2; i < s.Length; i+=2)
            {
                //logic for nextPair
                if (s.Length%2 != 0)
                {
                    if (i == s.Length - 1)
                    {
                        nextPair = s[i].ToString(); //convert char to string
                        count = 1;   //reset count to 1
                    }
                    else
                    {
                        nextPair = s.Substring(i, 2); //2 characters
                    }
                }
                else //even case
                {
                    //ensure index is not > length-2 to avoid the out of index error
                    nextPair = s.Substring(i, 2);
                }


                
                if (pair == nextPair)
                {
                    count++;
                }
                else
                {
                    //add pair to result
                    result += pair;
                    result += count.ToString();

                    //reset pair and count variable
                    pair = nextPair;
                    count = 1;
                }                           
            }

            //add last pair elements to result
            result += pair;
            result += count.ToString();

            Console.WriteLine(result);

            return result;
        }
    }
}
