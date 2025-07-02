using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunLengthEncodingInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution.EncodeRle("aaa@@bb!!c#d**e");
            Console.ReadLine();
        } 
    }

    public class Solution
    {
        public static string EncodeRle(string s)
        {
            // TODO: implement

            string result = "";
            int count = 0;
            char? group = null;
            string letter;
            string number;

            //foreach loop
            foreach (char ch in s)
            {
                //each character is digit or a alphabet
                if (Char.IsLetter(ch))
                {
                    // if group empty, then group = character
                    if (group == null)
                    {
                        group = ch;
                        count++;
                    }
                    // if group is not empty and char == group, count ++
                    else if (group != null && group == ch)
                    {
                        count++; //increase count increment by one
                    }
                    // if group is not equal to ch then group = char, count = 0
                    else if (group != ch)
                    {
                        letter = group.ToString();
                        number = count.ToString();
                        result += letter + number;

                        //reset group with ch
                        group = ch;
                        count = 1;
                    }
                }
            }

            //process the last letter and number
            letter = group.ToString();
            number = count.ToString();
            result += letter + number;

            Console.WriteLine(result);

            return result;
        }
    }
}
