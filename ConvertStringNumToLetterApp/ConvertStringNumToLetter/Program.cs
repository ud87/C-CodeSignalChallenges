// See https://aka.ms/new-console-template for more information
using System.Linq;

ConvertString("26-25-24-23-22");

static string ConvertString(string s)
{
    // TODO: Implement the function to solve the task

    //convert the string to a char array
    string[] words = s.Split('-');

    string[] modifiedArr = new string[words.Length];

    int modifiedArrIndex = 0;

    //loop through the char array
    foreach (string word in words)
    {
        string modifiedWord = "";

        //if char is a digit convert it to letter
        if (int.TryParse(word, out int num))
        {
            char letter = (char)(97 + num - 1); //'a' is 97 in ascii so we add to 97, 1 is subtracted to match the index and char is used to convert to letter
                                                //Console.WriteLine($"letter: {letter}");

            //add it to new modifiedWord
            modifiedWord += letter;
        }
        //if char is a letter convert it to digit
        else
        {
            // convert the letter to a digit by subtracting 'a' from it and adding 1, letter must be converted to char
            int digit = (int)char.Parse(word) - (int)'a' + 1;
            // add it to new modifiedArray
            //Console.WriteLine($"digit: {digit}");
            modifiedWord += digit.ToString();
        }

        modifiedArr[modifiedArrIndex] = modifiedWord;
        modifiedArrIndex++; //increment the index for modifiedArray
    }
    //create a new string and join using - in between digits and letters
    string result = string.Join("-", modifiedArr);
    Console.WriteLine(result);

    return result;
}
