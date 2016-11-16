using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GR_Awesome_Midterm;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Library.populateLibrary();
            InitializeComponent();
            checkButton.Visible = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void displayLibraryButton_Click(object sender, EventArgs e)
        {


            List<Book> AllBooks = Library.BookLibrary;
            checkButton.Visible = true;


            resultsListView.Columns.Add("Author");
            resultsListView.Columns.Add("Title");
            resultsListView.Columns.Add("ID");
            resultsListView.Columns.Add("Status");
            foreach (Book c in AllBooks)
            {

                ListViewItem LV = new ListViewItem(c.Author);
                LV.SubItems.Add(c.Title);
                LV.SubItems.Add(c.UniqueId);
                LV.SubItems.Add(c.Status.ToString());
                LV.SubItems.Add(c.ReturnDate);
                resultsListView.Items.Add(LV);
                resultsListView.View = View.Details;
                resultsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }

            resultsListView.Items[0].Selected = true;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            resultsListView.Clear();
            resultsListView.Columns.Add("Author");
            resultsListView.Columns.Add("Title");
            resultsListView.Columns.Add("ID");
            resultsListView.Columns.Add("Status");
            resultsListView.Columns.Add("Return Date");

            checkButton.Visible = true;
            Library.populateLibrary();
            List<Book> AllBooks = Library.BookLibrary;

            if (authorRadioButton.Checked == true)
            {

                foreach (Book b in AllBooks)
                {
                    string search = searchTextBox.Text;
                    if (b.Author.ToLower().Contains(search.ToLower()))
                    {
                        ListViewItem LV = new ListViewItem(b.Author);
                        LV.SubItems.Add(b.Title);
                        LV.SubItems.Add(b.UniqueId);
                        LV.SubItems.Add(b.Status.ToString());
                        LV.SubItems.Add(b.ReturnDate);
                        resultsListView.Items.Add(LV);

                    }
                }
            }
            else if (titleRadioButton.Checked == true)
            {
                foreach (Book b in AllBooks)
                {
                    string search = searchTextBox.Text;
                    if (b.Title.ToLower() == search.ToLower())
                    {
                        ListViewItem LV = new ListViewItem(b.Author);
                        LV.SubItems.Add(b.Title);
                        LV.SubItems.Add(b.UniqueId);
                        LV.SubItems.Add(b.Status.ToString());
                        LV.SubItems.Add(b.ReturnDate);
                        resultsListView.Items.Add(LV);

                    }
                }

            }
            else
            {

                foreach (Book b in AllBooks)
                {
                    string search = searchTextBox.Text;
                    if (b.Title.ToLower().Contains(search.ToLower()))
                    {
                        ListViewItem LV = new ListViewItem(b.Author);
                        LV.SubItems.Add(b.Title);
                        LV.SubItems.Add(b.UniqueId);
                        LV.SubItems.Add(b.Status.ToString());
                        LV.SubItems.Add(b.ReturnDate);
                        resultsListView.Items.Add(LV);

                    }
                }
            }
            resultsListView.View = View.Details;
            resultsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            resultsListView.Items[0].Selected = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


            foreach (ListViewItem item in resultsListView.SelectedItems)
            {
                titleTB.Text = item.SubItems[1].Text;
                string status = item.SubItems[3].Text;
                statusTB.Text = status;
                if (status.ToLower() == "available")
                {
                    checkButton.Text = "Check Out";
                }
                else
                {
                    checkButton.Text = "Return";
                }

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void returnDateTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkButton_Click(object sender, EventArgs e)
        {

            List<Book> BookLibrary = Library.BookLibrary;
            string thisText = this.Text;
            string UID = resultsListView.SelectedItems[0].SubItems[2].Text;
            string status = resultsListView.SelectedItems[0].SubItems[3].Text;
            DateTime Date = DateTime.Today.AddDays(14);
            string returnDate = Date.ToString("MM/dd/yyyy");


           

            if (status == "Available")
            {
                resultsListView.SelectedItems[0].SubItems[3].Text = "CheckedOut";
                resultsListView.SelectedItems[0].SubItems[4].Text = returnDate;
                statusTB.Text = "Checked Out";
                this.Text = "Return";
                checkButton.Text = "Return";
                MessageBox.Show("Due Back On " + returnDate);
                foreach (Book b in BookLibrary)
                {
                    if (b.UniqueId == UID)
                    {
                        b.Status = Book.Availability.CheckedOut;
                        b.ReturnDate = returnDate;
                    }
                }
            }
            else
            {
                resultsListView.SelectedItems[0].SubItems[3].Text = "Available";
                resultsListView.SelectedItems[0].SubItems[4].Text = "00/00/0000";
                statusTB.Text = "Available";
                this.Text = "Check Out";
                checkButton.Text = "Check Out";
                foreach (Book b in BookLibrary)
                {
                    if (b.UniqueId == UID)
                    {
                        b.Status = Book.Availability.Available;
                        b.ReturnDate = "00/00/0000";
                    }
                }

            }
            Library.writeToLibrary();
        }
    }
}
