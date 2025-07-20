using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseAndMultplyNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParseAndMultiplyNumbers("I have2apples and5oranges");
        }

        static int ParseAndMultiplyNumbers(string input)
        {
            string[] strings = input.Split(' ');

            List<int> numbers = new List<int>();

            foreach (string str in strings)
            {
                foreach (char c in str)
                {
                    if (int.TryParse(c.ToString(), out int numericValue))
                    {
                        numbers.Add(numericValue);
                    }
                }
            }

            int product = numbers.Aggregate(1, (current, number) => current * number);

            Console.WriteLine($"The product of the numbers is: {product}");
            return product;


        }
    }
}
