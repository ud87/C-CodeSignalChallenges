using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringHalfway
{
    class Program
    {
        static void Main(string[] args)
        {
            Program specialOrder = new Program();
            specialOrder.SpecialOrder("uday" +
                "" +
                "");
            Console.ReadLine();
        }

        public string SpecialOrder(string inputString)
        {
            // TODO: Implement function
            int length = inputString.Length;
            string result = "";
            string postHalf = "";

            //Console.WriteLine(Math.Ceiling(length / 2));
            //halfway - Math.Ceiling rounds up decimal numbers
            for (int i = 0; i < Math.Ceiling((double)length / 2); i++)
            {
                //add post half numbers as is apart from middle index
                if (i != Math.Ceiling((double)length / 2) - 1)
                {
                    postHalf += inputString[i];
                }

                //reverse string up to half length
                result += inputString[length - 1 - i];
                
            }
            
            result = result + postHalf;
            Console.WriteLine(result);
            
            return result;
        }
    }
}
