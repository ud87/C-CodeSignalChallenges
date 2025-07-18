using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Create a program that takes in string splits it into words, converts the words into opposite characters
 and then returns the last word followed by all the other words. 

e.g. "Hello World" should return Dliow Svool
 
 */


namespace StringSplitReplaceOppositeChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution.TransformString("Hello World");
        }
    }

    public class Solution
    {
        public static string TransformString(string inputStr)
        {
            // TODO: implement the string transformation function
            string[] words = inputStr.Split(' ');

            string[] modifiedWords = new string[words.Length];

            int modifiedWordsIndex = 0;


            foreach (string word in words)
            {
                // Initialize an empty string to hold the modified word
                string modifiedWord = "";

                foreach (char c in word)
                {
                    if (Char.IsUpper(c))
                    {
                        //calculate distance between c and 'A'
                        int distance = c - 'A';
                        int oppositeChar = 'Z' - distance;
                        modifiedWord += (char)oppositeChar;

                    }
                    else
                    {
                        //calculate distance between c and 'a'
                        int distance = c - 'a';
                        int oppositeChar = 'z' - distance;
                        //Console.WriteLine((char)oppositeChar);
                        modifiedWord += (char)oppositeChar;

                    }
                }

                // Add the modified word to the modifiedWords array
                modifiedWords[modifiedWordsIndex] = modifiedWord;
                modifiedWordsIndex++;
            }

            //extract last word from modifiedWords array
            string lastWord = modifiedWords.Last();
            // Remove the last word from the modifiedWords array
            string allExceptLast = string.Join(" ", modifiedWords.Take(modifiedWords.Length - 1));

            string result;

            // If there are no other words, just return the last word
            if (string.IsNullOrEmpty(allExceptLast))
            { 
                result = lastWord;
            }
            else
            {
                result = $"{lastWord} {allExceptLast}";
            }
            
            Console.WriteLine(result);

            return result;
        }
    }
}
