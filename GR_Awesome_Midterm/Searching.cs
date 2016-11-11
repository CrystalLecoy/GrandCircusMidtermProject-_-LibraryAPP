using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR_Awesome_Midterm
{
    public class Searching
    {
        public List<Book> search(SearchType type, string searchWord, List<Book> library)
        {

            List<Book> returnList =new List<Book>();

            switch (type)
            {
                case SearchType.Author:
                    foreach (Book book in library)
                    {
                        if (book.Author == searchWord)
                        {
                            returnList.Add(book);
                        }
                    }
                    break;
                case SearchType.Keyword:
                    foreach (Book book in library)
                    {
                        if (book.Title.Contains(searchWord))
                        {
                            returnList.Add(book);
                        }
                    }
                    break;
                case SearchType.Title:
                    foreach (Book book in library)
                    {
                        if (book.Title == searchWord)
                        {
                            returnList.Add(book);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Your search returned no results");
                    break;
                    
            }
            return returnList;
        }
        public enum SearchType
        {
            Author,
            Keyword,
            Title
    
        }
    }
}

