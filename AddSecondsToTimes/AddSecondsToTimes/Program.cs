using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddSecondsToTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] timePoints = new string[] { "01:02:03", "02:04:55" };
           AddSecondsToTimes(timePoints, 366);
            Console.ReadLine();
        }

        public static string[] AddSecondsToTimes(string[] timePoints, int addedSeconds)
        {
            // TODO: implement the function
            foreach (string time in timePoints)
            {
                Console.WriteLine(time);
                int hours = int.Parse
            }
            return new string[0]; // Placeholder
        }
    }
}
