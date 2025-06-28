using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnusualArrayTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7};
            Solution.UnusualTraversal(numbers);
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public static List<int> UnusualTraversal(List<int> array)
        {
            //find middle index
            int length = array.Count;

            int middle = length / 2;

            int left = middle - 2;
            int right = middle + 2;

            List<int> newArray = new List<int> { }; //new empty array
            newArray.Add(array[middle]);

            while (left >= 0 || right<length)
            {
                //add two element from left
                newArray.Add(array[left]);
                newArray.Add(array[left + 1]);

                //add two element from right
                newArray.Add(array[right - 1]);
                newArray.Add(array[right]);

                left -= 2;
                right += 2;

            }
            

            //if left is less than 0 or right is equal/greater than index length 
            if (left < 0)
            {
                //final odd ones will always be 0 index for left and length - 1 index for right
                newArray.Add(array[0]);
            }

            if (right >= length)
            {
                newArray.Add(array[length - 1]);
            }


            //less than two elements on left or right
            //include all elements
                Console.WriteLine(string.Join(", ", newArray));

            return newArray;
        }
    }
}
