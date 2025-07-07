using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello, C#!";
            string encryptedText = EncryptString(text);
            Console.WriteLine("The encrypted text is: " + encryptedText);  // Should print out "The encrypted text is Ifmmp, D#!"
            Console.ReadLine();
        }

        static string EncryptString(string text)
        {
            char[] encrypted = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                // TODO: Check if `c` is a letter different from 'z' and 'Z'. If so, increment by 1.
                // If `c` is 'z', change it to 'a'. If `c` is 'Z', change it to 'A'.
                // Otherwise, keep `c` unchanged and add it to the encrypted list.

                //solution
                //convert char c to decimal
                decimal dec = c;

                if (char.IsLetter(c))
                {
                    //if lower case
                    if (Char.IsLower(c))
                    {
                        if (c == 'z')
                        {
                            encrypted[i] = 'a';
                        }
                        else
                        {
                            dec = dec + (decimal)1; //add one to decimal and convert to char
                  
                            c = (char)dec; //convert to char
                            //Console.WriteLine(c);
                            encrypted[i] = c;
                        }
                    }
                    else //upper case
                    {
                        if (c == 'Z')
                        {
                            encrypted[i] = 'A';
                        }
                        else
                        {
                            dec = dec + (decimal)1; //add one to decimal and convert to char
                            c = (char)dec; //convert to char
                            //Console.WriteLine(c);
                            encrypted[i] = c;
                        }

                    }
                }
                else encrypted[i] = c;  
            }

            /*
            foreach (char c in encrypted)
            {
                Console.WriteLine(c);
            }*/

            return new string(encrypted);
        }
    }
}
