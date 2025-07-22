/*
 Your task is to write a C# method named SumPlayerScores. This method should parse the string, isolate 
the integers which represent player scores, and return the total sum of these scores.

For example, given an input string "joe scored 5 points, while adam scored 10 points and bob scored 2, 
with an extra 1 point scored by joe", the method should return the sum of 5 + 10 + 2 + 1, which equals 18. 
 */


// See https://aka.ms/new-console-template for more information
using static System.Runtime.InteropServices.JavaScript.JSType;

ScoreParser.SumPlayerScores("joe scored5points, while adam scored 10 points and bob scored 2, with an extra 1 point scored by joe.");

public class ScoreParser
{
    public static int SumPlayerScores(string inputString)
    {
        //TODO: implement the SumPlayerScores funciton
        string[] words = inputString.Split(' ');
        
        List<int> scores = new List<int>();

        foreach (string word in words)
        {
            string scoreString = "";
            int number;

            foreach (char c in word)
            {
                if (int.TryParse(c.ToString(), out number))
                {
                    //add the number as string to score, remember there could be more than one digit so stored as string e.g. adam10points
                    scoreString += number.ToString();
                }
            }
            
            if (!string.IsNullOrEmpty(scoreString)) //if scoreString is not empty
            {
                scores.Add(int.Parse(scoreString));  //convert to int before adding to scores, and add to scores
            }
        }

        int totalScore = scores.Aggregate(0, (acc, score) => acc + score); //acc is the accumulator, score is the current value obtained from scores list
        Console.WriteLine(totalScore);
        return totalScore;
    }
}