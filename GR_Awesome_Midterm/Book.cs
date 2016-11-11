using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR_Awesome_Midterm
{
    public class Book
    {
        public Book(string Title, string Author, string Status, string dueDate)
        {
            this.title = Title;
            this.author = Author;
            if (Status.ToLower() == "checkedout")
            {
                this.status = (Availability)0;
            }
            else
            {
                this.status = (Availability)1;
            }
            this.returnDate = dueDate;
        }
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        private Availability status;

        public Availability Status
        {
            get { return status; }
            set { status = value; }
        }

        public enum Availability
        {
            CheckedOut,
            Available
        }

        private string isbn;

        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        private string returnDate;

        public string ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }

        
    }
}
