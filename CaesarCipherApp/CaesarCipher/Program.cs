/*
 you will implement the encryption logic for the Caesar Cipher in C#
from scratch. The Caesar Cipher is a simple encryption technique where
each letter in the plaintext is shifted by a fixed number of positions 
in the alphabet.

To clarify how the Caesar Cipher works, here are some examples:

Example 1: The string "abc" shifted by 3 positions becomes "def".
Example 2: The string "xyz" shifted by 3 positions becomes "abc".
Example 3: The string "Hello, World!" shifted by 3 positions becomes 
"Khoor, Zruog!".
Your task is to fill in the placeholders in the provided starter 
code to correctly implement this shifting logic using ASCII values.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example text to encrypt
            string originalText = "Zello, C#!";
            // The encrypted_text function call and Console.WriteLine statement should be the same as in the solution
            string encryptedText = EncryptText(originalText);
            Console.WriteLine(encryptedText);  // The correct output after implementing the TODO should be 'Khoor, F#!'
            Console.ReadLine();
        }

        public static string EncryptText(string text)
        {
            string encrypted = "";
            for (int i = 0; i < text.Length; i++)  // use for loop
            {
                char c = text[i];  // get the character at the current index
                if (char.IsLetter(c))  // check if the character is an alphabet
                {
                    int shift = 3;
                    // TODO: Use the correct ASCII values to shift the character and add it to 'encrypted'
                    encrypted += char.IsUpper(c)
                        ? (decimal)c - 64 % 26 == 0
                            ? (char)(65 + shift)
                            : (char)((decimal)c + shift)
                        : (decimal)c - 96 % 26 == 0
                            ? (char)(97 + shift)
                            : (char)((decimal)c + shift);
                    // Hint 1: 'A' = 65, 'a' = 97
                    // Hint 2: you can use modulo (%) operator to create a cycle

                    // Example:
                    // Let's consider 'A', whose ASCII value is 65.
                    // Applying the shift of 3, we get: (65 - 65 + 3) % 26 + 65
                    // This simplifies to: 3 % 26 + 65 = 3 + 65 = 68, which corresponds to 'D'.
                    // Therefore, 'A' shifts to 'D'.
                }
                else
                {
                    encrypted += c;  // keep non-alphabet characters unchanged
                }
            }
            return encrypted;
        }
    }
}
