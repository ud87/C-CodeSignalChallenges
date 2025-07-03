/*
 Your function should return a list of tuples. Each tuple will consist 
of the repeating character and the number of its repetitions. For instance, 
if the input string is "aaabbcccdde", the function should output: 
[('e', 1), ('d', 2), ('c', 3), ('b', 2), ('a', 3)].

Note that the input string cannot be empty; in other words, it must 
contain at least one character, and its length must not exceed 500 
characters. The return should also be in reverse order, starting 
from the group of repeated characters at the end of the string 
and moving backward.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentifyingConsecutiveCharacterGroupsInReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            GetConsecutiveGroupsReverse("aaabbcccdde");
            Console.ReadLine();
        }

        public static List<(char, int)> GetConsecutiveGroupsReverse(string s)
        {
            // TODO: implement the algorithm to find consecutive groups of characters in the reverse order

            //Reverse the string
            string reverseString = "";
            char group;

            for (int i = s.Length-1; i>=0; i--)
            {
                reverseString += s[i];
            }

            var result = new List<(char, int)> { };
            Console.WriteLine(reverseString);

            //set group as first character of reverseString
            group = reverseString[0];
            int count = 0;  //initial count

            foreach (char ch in reverseString)
            {
                if (ch == group)
                {
                    count++;
                }
                else
                {
                    result.Add((group, count));
                    group = ch;  //reset group to new character
                    count = 1; //reset count to 1;
                } 
            }
            result.Add((group, count));

            Console.WriteLine(string.Join(" , ", result));

            return result;
        }
    }

}
