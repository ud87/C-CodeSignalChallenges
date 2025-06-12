/*
 In this task, you are given a string composed of lowercase English 
alphabet letters ('a' to 'z'). The length of the string will range 
from 1 to 100 characters. Your challenge is to create a new string 
resulting from a unique order of character selection from the 
original string.

You need to develop a C# function, SpecialOrder(string inputString),
which takes inputString as an argument. The resulting string begins 
with the last character of the inputString, then selects the 
second-to-last character, continuing in reverse order until you 
reach the middle character of the string. Then, start with the 
first character of the inputString, proceed to the second character,
and continue in this manner until you reach the middle character.

For example, if the inputString is "abcdefg", the function should 
return "gfedabc".

Keep in mind the following constraints while creating your function:



The input string contains only lowercase English letters ('a' to 'z').
The length of the input string is between 1 and 100, inclusive.
 
 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringHalfway
{
    class Program
    {
        static void Main(string[] args)
        {
            Program specialOrder = new Program();
            specialOrder.SpecialOrder("udxya");
            Console.ReadLine();
        }

        public string SpecialOrder(string inputString)
        {
            // TODO: Implement function
            int length = inputString.Length;
            string result = "";
            string postHalf = "";

            //Console.WriteLine(Math.Ceiling(length / 2));
            //halfway - Math.Ceiling rounds up decimal numbers
            for (int i = 0; i < Math.Ceiling((double)length / 2); i++)
            {
                //add post half numbers as is apart from middle index
                if (length % 2 == 0)
                {
                    if (i != Math.Ceiling((double)length / 2))
                    {
                        postHalf += inputString[i];
                    }
                }
                else
                {
                    if (i != Math.Ceiling((double)length / 2) - 1)
                    {
                        postHalf += inputString[i];
                    }
                }
                

                //reverse string up to half length
                result += inputString[length - 1 - i];
                
            }
            
            result = result + postHalf;
            Console.WriteLine(result);
            
            return result;
        }
    }
}
