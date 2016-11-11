using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR_Awesome_Midterm
{
   public class Book
    {
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

        private DateTime returnDate;

        public DateTime ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }


    }
}
