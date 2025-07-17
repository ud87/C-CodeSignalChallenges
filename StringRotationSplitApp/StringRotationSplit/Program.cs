/*
 You are given a string of n characters, with n varying from 1 to 1000, inclusive. Your task is to write
a C# function that takes this string as input, applies the following operations, and finally returns the
resulting string.

Split the given string into individual words, using a space as the separator.
Convert each word into a list of its constituent characters, and shift each list once to the right (with
the last element moving to the first position).

After the rotations, reassemble each word from its list of characters.
Join all the words into a single string, separating adjacent words with a single space.
Return this final string as the function's output.
The constraints for the problem are as follows:

The input string will neither start nor end with a space, nor will it have multiple consecutive spaces.
Each word will contain only alphabets and digits, and its length will range from 1 to 10.
Your program should output a single string with the words rotated by their lengths while preserving 
their original order.

As an illustration, consider the input string "abc 123 def". Applying the stated operations results in 
the output "cab 312 fde".
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRotationSplit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution.Transform("abf 123 dff");
        }
    }
}

public class Solution
{
    public static string Transform(string inputStr)
    {
        // TODO: Implement the solution here
        string[] words = inputStr.Split(' ');

        string[] resultArray = new string[words.Length];

        int i = 0;

        foreach (string word in words)
        {
            //assign last character to a variable and then iterate through the word
            string modifiedWord = word[word.Length - 1].ToString();

            int index = 0;

            // iterate through the word except the last character
            foreach (char c in word)
            {
                if (index != word.Length - 1) //only add c if it is not the last character
                {
                    modifiedWord +=  c; 
                }
                index++;
            }

            resultArray[i] = modifiedWord;
            i++;

            /* Alternatively, you can use string concatenation and substring method
            string modifiedWord = word[word.Length - 1] + word.Substring(0, word.Length - 1);
            Console.WriteLine(modifiedWord);
            */
        }

        string result = string.Join(" ", resultArray);
        Console.WriteLine(result);

        return result;
    }
}
