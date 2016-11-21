using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GR_Awesome_Midterm;

namespace WindowsFormsApplication1
{
    public partial class ucAddBook : UserControl
    {
        string titlePlaceholder = "Enter Title Here";
        string authorPlaceholder = "Enter Author, First and Last Name, Here";
        private Book _lastBookAdded;

        public Book Book
        {
            get { return _lastBookAdded; }
            set { _lastBookAdded = value; }
        }

        public ucAddBook()
        {
            InitializeComponent();
            textBoxAddTitle.Text = titlePlaceholder;
            textBoxAddAuthor.Text = authorPlaceholder;
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            Book b = Library.AddBookToLibrary(textBoxAddTitle.Text, textBoxAddAuthor.Text);
            MessageBox.Show("Your book was successfully added!");
            textBoxAddTitle.Text = titlePlaceholder;
            textBoxAddAuthor.Text = authorPlaceholder;
            _lastBookAdded = Book;
        }

        private void textBoxAddTitle_Enter(object sender, EventArgs e)
        {
            if (textBoxAddTitle.Text == titlePlaceholder)
            {
                textBoxAddTitle.Text = "";
            }
        }

        private void textBoxAddAuthor_Enter(object sender, EventArgs e)
        {
            if (textBoxAddAuthor.Text == authorPlaceholder)
            {
                textBoxAddAuthor.Text = "";
            }
        }
    }
}
