using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMgmtSplit
{
    class Program
        {
            static void Main(string[] args)
            {
                // A small piece of code that manages book data.
                // This code will process a simple string containing book data.

                string bookData = "1984,Fiction|War and Peace,Historical|Harry Potter,Fantasy";
                // Splitting the book data by '|' to separate each book's info
                string[] bookList = bookData.Split('|');

                // TODO: For each book, create a formatted string with stripped details and genre popularity note
                for (int i = 0; i < bookList.Length; i++)
                {
                    // TODO: Parse the book data and add popularity note if applicable
                    string[] book = bookList[i].Split(',');
                    string title = book[0];
                    string genre = book[1];
                    string popularity = (genre == "Fiction" || genre == "Fantasy") ? " - Popular" : "";
                    Console.WriteLine($"Title: {title} - Genre: {genre}{popularity}");
                    // Example: Title: 1984 - Genre: Fiction - Popular
                }

            Console.ReadLine();
            }
        }
}
