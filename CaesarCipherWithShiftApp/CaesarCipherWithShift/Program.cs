/*
 Write a program that takes text and an integer as a shift value to 
encrypt it by shifting each letter by the shift value in the 
alphabet. Non-alphabetic characters should remain the same.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipherWithShift
{
    class Program
    {
        static void Main(string[] args)
        {
            // Encrypt the text with a shift of 3
            Console.WriteLine(EncryptText("Hello, C#!", 3));  // Outputs: Khoor, F#!
            Console.ReadLine();
        }

        static string EncryptText(string text, int shift)
        {
            string encrypted = "";
            // TODO: Inside the function, create a loop that goes through each character of the text
            // You should use a for loop here
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                // TODO: Check if the current character is an alphabetic character
                if (Char.IsLetter(c))
                {
                    // TODO: Perform the character shift operation and append the result to the encrypted text
                    // Hint: Use 'Char.ToLower', 'Char.ToUpper', and modulo (%) operations to cyclically shift the letter by `shift`

                    // Example shift operation:
                    // 'a' with shift 1: ((('a' - 'a') + 1) % 26) + 'a' = 'b'
                    // 'A' with shift 1: ((('A' - 'A') + 1) % 26) + 'A' = 'B'
                    if (Char.IsUpper(c))
                    {
                        encrypted += (char)(((c - 'A' + shift) % 26) + 'A');
                    }
                    else
                    {
                        encrypted += (char)(((c - 'a' + shift) % 26) + 'a');
                    }
                }
                // If the character is not alphabetic, add it as is to the encrypted text
                else
                {
                    encrypted += c;
                }
            }

            // Outside the function, call your `EncryptText` function with some sample text and a shift value to test it
            return encrypted;
        }
    }
}
