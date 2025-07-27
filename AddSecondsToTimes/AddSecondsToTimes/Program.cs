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
           AddSecondsToTimes(timePoints, 90000);
            Console.ReadLine();
        }

        public static string[] AddSecondsToTimes(string[] timePoints, int addedSeconds)
        {
            string[] newTimePoints = new string[timePoints.Length];
            int counter = 0;

            // TODO: implement the function
            foreach (string time in timePoints)
            {
                string[] parts = time.Split(':');

                int hours = int.Parse(parts[0]);
                int minutes = int.Parse(parts[1]);
                int seconds = int.Parse(parts[2]);

                // convert everything into seconds and add addedSeconds
                int secondsSinceStart = hours * 60 * 60 + minutes * 60 + seconds;
                int totalSeconds = (secondsSinceStart + addedSeconds) % (3600 * 24); // 24 hours in seconds

                int newHours = totalSeconds / 3600;
                int remainder = totalSeconds % 3600;
                int newMinutes = remainder / 60;
                int newSeconds = remainder % 60;

                newTimePoints[counter] = string.Format("{0:D2}:{1:D2}:{2:D2}", newHours, newMinutes, newSeconds);
                Console.WriteLine(newTimePoints[counter]);
                counter++;         
            }

            return newTimePoints; // Placeholder
        }
    }
}
