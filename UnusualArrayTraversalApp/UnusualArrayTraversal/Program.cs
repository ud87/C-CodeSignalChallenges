/*
You are provided with an array of n integers, where n ranges from 
1 to 501 and is always an odd number. The goal is to return a new array constructed 
by traversing the initial array in a specific order, outlined as follows:

Begin with the middle element of the array.
For each subsequent pair of elements, alternate between taking two elements from the 
left and two elements from the right, relative to the middle.
If fewer than two elements remain on either side, include all the remaining 
elements from that side.Continue this process until all elements of the array have 
been traversed.
For example, for array = [1, 2, 3, 4, 5, 6, 7], your function should 
return [4, 2, 3, 5, 6, 1, 7]. And for array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11], 
your function should return [6, 4, 5, 7, 8, 2, 3, 9, 10, 1, 11].
 */

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
            List<int> numbers = new List<int> { 3, 1, 2, 4, 5, 1, 5 };
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

            int left = middle - 1;
            int right = middle + 1;

            List<int> newArray = new List<int> { }; //new empty array
            newArray.Add(array[middle]);

            while (left >= 0 || right<length)
            {
                //add two element from left
                if (left >= 0)
                {
                    if (left >= 0 && left - 1 >= 0)
                    {
                        newArray.Add(array[left - 1]);
                        newArray.Add(array[left]);

                        Console.WriteLine($"Left: {left}");
                    }
                    else newArray.Add(array[left]);
                    left -= 2;
                }
                
                if (right < length) //add two element from right
                {
                    if (right < length && right + 1 < length)
                    {
                        newArray.Add(array[right]);
                        newArray.Add(array[right + 1]);
                        Console.WriteLine($"Right: {right}");
                    }
                    else newArray.Add(array[right]);
                    right += 2;
                }

                
            }


            Console.WriteLine("Hello");
            Console.WriteLine(string.Join(", ", newArray));

            return newArray;
        }
    }
}
