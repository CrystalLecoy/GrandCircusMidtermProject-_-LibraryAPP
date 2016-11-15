using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR_Awesome_Midterm
{
    public class ConsoleApp
    {
        public void Answers()
        {
            Library.populateLibrary();
            List<Book> fullLibrary = Library.BookLibrary;

            Console.Write("List all books? (y/n)");
            string userAnswer = Console.ReadLine();
            if (userAnswer.ToLower() == "y" || userAnswer.ToLower() == "yes")
            {
                //list all books
            }
            string userChoice;
            do
            {
                Console.Write("Select search option (\"author\", \"title\", or \"keyword: \"");
                userChoice = Console.ReadLine();

                if (userChoice.ToLower() == "author")
                {
                    Console.Write("Please enter author's name: ");
                    string userAuthor = Console.ReadLine();                   
                }
                else if (userChoice.ToLower() == "title")
                {
                    Console.Write("Please enter title: ");
                    string userTitle = Console.ReadLine();
                    //todo return list of books
                }
                else if (userChoice.ToLower() == "")
                {
                    Console.Write("Please enter keyword: ");
                    string userKeyword = Console.ReadLine();
                    //todo return list of books
                }
            }
            while (userChoice.ToLower() != "author" || userChoice.ToLower() != "title" || userChoice.ToLower() != "keyword");

            string checkOrReturn;
            do
            {
                Console.Write("Would you like to check out or return a book? (\"check out\"/\"return\")");
                checkOrReturn = Console.ReadLine();

                if (checkOrReturn.ToLower() == "check out" || checkOrReturn.ToLower() == "checkout")
                {
                    Console.Write("Which book would you like to check out? ");
                    //todo figure out how they choose which book. is the list numbered?
                    string userBook = Console.ReadLine();
                   
                    //todo check to see book's availability

                    //todo if available, run pool so that the book is now unavailable
                    //todo set return date

                    //todo if not, say unavailable and ask if they want a different one
                    //todo continue until a book is available or they say no
                }
                else
                {
                    //todo return book to pool
                }
            }
            while (checkOrReturn.ToLower() != "check out" || checkOrReturn.ToLower() != "return");
        }
    }
}
