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
            foreach (Book b in AllBooks)
            {
                string titleAuth = b.Author + "\t\t" + b.Title;
                listBox1.Items.Add(titleAuth);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Library.populateLibrary();
            List<Book> AllBooks = Library.BookLibrary;

            if (authorRadioButton.Checked = true)
            {
                
                foreach (Book b in AllBooks)
                {
                    string search = searchTextBox.Text;
                    if (b.Author.ToLower().Contains(search.ToLower()))
                    {
                        string titleAuth = b.Author + "\t\t" + b.Title;
                        listBox1.Items.Add(titleAuth);
                    }
                }
            }
            else if(titleRadioButton.Checked = true)
            {
                foreach (Book b in AllBooks)
                {
                    string search = searchTextBox.Text;
                    if (b.Title.ToLower() == search.ToLower())
                    {
                        string titleAuth = b.Author + "\t\t" + b.Title;
                        listBox1.Items.Add(titleAuth);
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
                        string titleAuth = b.Author + "\t\t" + b.Title;
                        listBox1.Items.Add(titleAuth);
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
