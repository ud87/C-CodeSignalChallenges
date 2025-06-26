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
            return new List<(int, int)>();
        }
    }
}
