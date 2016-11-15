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
        public static List<Book> BookLibrary;

        public static void populateLibrary()
        {
            StreamReader SR = new StreamReader("Library.txt");
            string line;
            BookLibrary = new List<Book>();
         
            while ((line = SR.ReadLine()) != null)
            {
                string[] lines = line.Split(';');
                Book e = new Book(lines[0], lines[1], lines[2], lines[3]);
                BookLibrary.Add(e);
            }
            
        
            
        }
    }
}
