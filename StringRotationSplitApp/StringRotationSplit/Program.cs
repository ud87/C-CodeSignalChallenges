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

            // iterate through the word except the last character
            foreach (char c in word)
            {
                if (c != word[word.Length - 1] && i != word.Length)
                {
                    modifiedWord +=  c; 
                }
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

        return null;
    }
}
