/*
 Create a program that takes an array and returns the middle of number and then places the 
left and the right digits 

for e.g. [1, 2, 3, 4, 5] should return [3, 2, 4, 1, 5]
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleElementAlternateLeftRightElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] numbers = new int[] {1, 2, 3, 4, 5};
            solution.MiddleElementAlternateLeftRight(numbers);
            Console.ReadLine();
        }

        public class Solution
        {
            public Array MiddleElementAlternateLeftRight(int[] arr)
            {
                int forwardIndex = 0;
                int backIndex = 0;
                int frontCounter = 1;  //count the element index forwards
                int backCounter = 1;  //count the element index backwards

                int length = arr.Length;

                //initialize an empty array equal to arr length
                int[] resultArr = new int[length];


                //even case
                if (length % 2 == 0)
                {
                    int middleLeftIndex = length / 2 - 1;
                    int middleRightIndex = length / 2;

                    resultArr[0] = arr[middleLeftIndex];
                    resultArr[1] = arr[middleRightIndex];

                    for (int i = 2; i < length; i++)
                    {

                        //if forwardIndex greater than equal to zero and index odd
                        if (forwardIndex >= 0 && i % 2 == 0)
                        {
                            forwardIndex = middleLeftIndex - frontCounter;
                            Console.WriteLine($"forward Index: {forwardIndex}");
                            resultArr[i] = arr[forwardIndex];
                            frontCounter++;
                        }

                        if (backIndex < length && i % 2 != 0)
                        {
                            backIndex = middleRightIndex + backCounter;
                            resultArr[i] = arr[backIndex];
                            backCounter++;
                        }

                    }

                }
                else  //odd case
                {
                    int middleIndex = length / 2;

                    resultArr[0] = arr[middleIndex];

                    for (int i = 1; i < length; i++)
                    {

                        //if forwardIndex greater than equal to zero and index odd
                        if (forwardIndex >= 0 && i % 2 != 0)
                        {
                            forwardIndex = middleIndex - frontCounter;
                            Console.WriteLine($"forward Index: {forwardIndex}");
                            resultArr[i] = arr[forwardIndex];
                            frontCounter++;
                        }

                        if (backIndex < length && i % 2 == 0)
                        {
                            backIndex = middleIndex + backCounter;
                            resultArr[i] = arr[backIndex];
                            backCounter++;
                        }
                    }
                }

                 
                foreach (int number in resultArr)
                {
                    Console.WriteLine(number);
                }
             
                return resultArr;
            }
        }

    }
}
