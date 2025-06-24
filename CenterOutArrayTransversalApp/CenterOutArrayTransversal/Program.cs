using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterOutArrayTransversal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 1, 2, 3, 4, 5 };
            Solution.Solve(num);
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public static List<int> Solve(int[] numbers)
        {
            // TODO: Implement the solution here
            int left;
            int right;
            
            List<int> newOrder = new List<int> {};

            //find the middle index
            int middleIndex = numbers.Length / 2;

            //if odd
            if (numbers.Length%2 != 0)
            {
                //add middle index to list
                newOrder.Add(numbers[middleIndex]);

                left = middleIndex - 1; 
                right = middleIndex + 1;
            }
            else //if even
            {
                left = middleIndex - 1;
                right = middleIndex;
            }

            while (left >= 0 && right < numbers.Length)
            {
                int tempNum = numbers[left] * numbers[right];
                newOrder.Add(tempNum);

                left--;
                right++;
            }

            Console.WriteLine(string.Join(" , ", newOrder));
            return newOrder;
        }
    }
}
