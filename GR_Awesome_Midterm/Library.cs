using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static GR_Awesome_Midterm.Book;

namespace GR_Awesome_Midterm
{
    public class Library
    {
        public static Book AddBookToLibrary(string title, string author)
        {
            string Status = Availability.Available.ToString();
            string dueDate = "00/00/0000";
            
            var lastBook = BookLibrary.OrderByDescending(b => b.UniqueId).First();

            string uniqueId = lastBook.UniqueId;
            int newIDNumber = int.Parse(uniqueId);
            newIDNumber++;

            Book newBook = new Book(title, author, Status, dueDate, newIDNumber.ToString("000000"));
            BookLibrary.Add(newBook);
            writeToLibrary();
            return newBook;
        }
        
        public static List<Book> BookLibrary;
        public static void writeToLibrary()
        {
            StreamWriter SW = new StreamWriter("Library.txt");
            foreach(Book b in BookLibrary)
            {
                string Line = b.Title + ";";
                Line = Line + b.Author + ";";
                Line = Line + b.Status + ";";
                Line = Line + b.ReturnDate + ";";
                Line = Line + b.UniqueId + ";";
                SW.WriteLine(Line);
                
            }
            SW.Close();
        }
        public static void populateLibrary()
        {
            StreamReader SR = new StreamReader("Library.txt");
            string line;
            BookLibrary = new List<Book>();
         
            while ((line = SR.ReadLine()) != null)
            {
                string[] lines = line.Split(';');
                Book e = new Book(lines[0], lines[1], lines[2], lines[3],lines[4]);
                BookLibrary.Add(e);
            }


            SR.Close();
        }
    }
}
