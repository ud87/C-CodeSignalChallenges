/*
Transform a string by moving the first letter after each number to before the number, removing any intermediate 
characters.

Example:
Input: "I have 2 apples and 5! oranges and 3 grapefruits."
Output: "I have a2pples and o5ranges and g3rapefruits."

Rules:

Numbers are always followed by at least one letter.

Remove spaces/punctuation between the number and the moved letter.

Preserve the original order of numbers and text.

Constraints:

String length: 3 to 10^6

At least one number exists.

Numbers are non-negative integers.

Goal: Manipulate strings efficiently in C#.
 
 */


// See https://aka.ms/new-console-template for more information

StringTransformer.TransformString("I have 2 apples and 5! oranges and 3 grapefruits.");

public class StringTransformer
{
    public static string TransformString(string inputString)
    {
        // TODO: implement your solution here
        string[] words = inputString.Split(" ");

        List<string> modifiedWordsList = new List<string>(); //new list to add modified words

        string tempNumberHolder = "";    //to hold number

        foreach (string word in words)
        {
            string tempStringHolder = "";     //reset string everytime new word is looped

            foreach (char ch in word)
            {
                if (ch == '!')
                {
                    continue;      //ignore ! and dont add it to temp string holder
                }
                else if(char.IsDigit(ch))
                {
                    tempNumberHolder += ch.ToString();   //add to tempNumberHolder if ch is a digit
                }
                else if (tempNumberHolder.Length > 0)
                {
                    tempStringHolder = ch + tempNumberHolder;     
                    tempNumberHolder = "";     //reset tempNumberHolder
                }
                else
                {
                    tempStringHolder += ch.ToString();
                }
            }


            if (tempStringHolder.Length > 0)    //dont add to array if tempStringHolder is empty
            {
                modifiedWordsList.Add(tempStringHolder);
            }
                      
        }

        string result = string.Join(" ", modifiedWordsList);
        Console.WriteLine(result);

        return result;
    }
}