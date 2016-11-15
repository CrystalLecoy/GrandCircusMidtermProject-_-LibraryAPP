using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR_Awesome_Midterm
{
    public class Book
    {
        public Book(string Title, string Author, string Status, string dueDate, string uniqueId)
        {
            this.title = Title;
            this.author = Author;
            this.uniqueId = uniqueId;

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

        private string uniqueId;

        public string UniqueId
        {
            get { return uniqueId; }
            set { uniqueId = value; }
        }

        private string returnDate;

        public string ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }

        
    }
}
