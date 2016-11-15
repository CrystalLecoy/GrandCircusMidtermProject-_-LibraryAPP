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
            InitializeComponent();
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

            Library.populateLibrary();
            List<Book> AllBooks = Library.BookLibrary;

            resultsListView.Columns.Add("Author");
            resultsListView.Columns.Add("Title");
            resultsListView.Columns.Add("ID");
            resultsListView.Columns.Add("Status");
            foreach (Book c  in AllBooks)
            {
                
                ListViewItem LV = new ListViewItem(c.Author);
                LV.SubItems.Add(c.Title);
                LV.SubItems.Add(c.UniqueId);
                LV.SubItems.Add(c.Status.ToString());
                resultsListView.Items.Add(LV);
                resultsListView.View = View.Details;
                resultsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            resultsListView.Clear();
            resultsListView.Columns.Add("Author");
            resultsListView.Columns.Add("Title");
            resultsListView.Columns.Add("ID");
            resultsListView.Columns.Add("Status");
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
                        resultsListView.Items.Add(LV);

                    }
                }
            }
            else if(titleRadioButton.Checked == true)
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
                        resultsListView.Items.Add(LV);
                        
                    }
                }
            }
            resultsListView.View = View.Details;
            resultsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
