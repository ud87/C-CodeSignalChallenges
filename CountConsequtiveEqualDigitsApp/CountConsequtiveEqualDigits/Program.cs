/*
You are tasked with writing a method that takes a positive integer, 
n, as an input and returns the number of consecutive equal digits 
in the number. Specifically, your method should identify pairs of 
digits in n that are equal and consecutive and return the count of 
these pairs.

For instance, if n = 113224, it contains two groups of consecutive 
equal digits: 11 and 22.Therefore, the output should be 2. For 
n = 444, the output should also be 2, as there are two groups of 
44 in this number.

Keep in mind that n will be a positive integer ranging from 
1 to 100,000,000, inclusive.

Note: You are not permitted to convert the number into a string 
or any other iterable structure for this task. You should work 
directly with the number.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountConsequtiveEqualDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountConsecutiveEqualDigits(111));
            Console.ReadLine();
        }

        public static int CountConsecutiveEqualDigits(int n)
        {
            // TODO: implement
            int lastDigit;
            int newLastDigit;
            int result = 0;

            while (n > 0)
            {
                lastDigit = n % 10;

                n = n / 10;

                if (n == 0)
                {
                    break;
                }
                else
                {
                    newLastDigit = n % 10;
                    if (lastDigit == newLastDigit)
                    {
                        result++;
                    }
                }
            }

            return result;
        }
    }
}
