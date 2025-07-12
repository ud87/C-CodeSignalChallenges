using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitJoinChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string astronautsData = "Buzz Aldrin, 1930;Yuri Gagarin, 1934;Valentina Tereshkova, 1937";

            // Splitting the string into a list of astronaut info and stripping any whitespace
            string[] astronautsList = astronautsData.Split(';');
            string[] cleanedAstronauts = new string[astronautsList.Length];

            for (int i = 0; i < astronautsList.Length; i++)
            {
                string[] parts = astronautsList[i].Split(',');
                //cleanedAstronauts[i] = parts[0].Trim() + " " + parts[1].Trim(); // Modify this line to use the Join() method
                string name = parts[0].Trim();
                string year = parts[1].Trim();
                cleanedAstronauts[i] = string.Join(" ", name, year);
            }

            Console.WriteLine(string.Join(", ", cleanedAstronauts)); // Output: "Buzz Aldrin 1930, Yuri Gagarin 1934, Valentina Tereshkova 1937"
            Console.ReadLine();
        }
    }
    
}
