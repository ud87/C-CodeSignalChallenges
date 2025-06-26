/*
 You are given an array of n integers, where n can range from 1 to 500, 
inclusive. Your task is to create a new array in which each element is 
a tuple, determined by pairing elements from the middle to both ends of 
the original array.

If the original array has an odd length, pair the middle element with 0. 
If the original array has an even length, start pairing from the two 
middle elements. Continue the pairing by alternating elements from the 
left and the right until all elements have been paired.

After creating the paired elements, return the new array of tuples. 
Ultimately, your result should be an array of tuples, each of size two, 
where each element within a tuple, as well as within the array, can range 
from -1000 to 1000, inclusive.

Note: You are not allowed to use built-in methods that reverse the order 
of elements, such as the Reverse() method.

For example, if the input is numbers = [1, 2, 3, 4, 5], the output should 
be [(3, 0), (2, 4), (1, 5)]. Similarly, if the input is numbers = [1, 2, 3, 4], 
the output should be [(2, 3), (1, 4)].
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairingElementsFromMiddleToEnds
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = new List<int> { 1, 2, 3, 4, 5, 6 };
            Solution.Solve(numbersList);
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public static List<(int, int)> Solve(List<int> numbers)
        {
            // TODO: Implement the function to pair the elements from the middle to ends of the list
            int middle;
            int length = numbers.Count;

            int left;
            int right;

            //empty tuple
            List<(int, int)> tupleResult = new List<(int, int)>{ };

            //odd case
            if (length%2 != 0)
            {
                middle = numbers.Count / 2;
                tupleResult.Add((numbers[middle], 0));
                left = middle - 1;
                right = middle + 1;
            }
            //even case
            else
            {
                middle = numbers.Count / 2 - 1;
                left = middle - 1;
                right = middle + 2;
                tupleResult.Add((numbers[middle], numbers[middle + 1]));
            }

            while (left >= 0 && right < length)
            {
                tupleResult.Add((numbers[left], numbers[right]));
                left--;
                right++;
            }

            Console.WriteLine(string.Join(", ", tupleResult));
            return tupleResult;
        }
    }
}
