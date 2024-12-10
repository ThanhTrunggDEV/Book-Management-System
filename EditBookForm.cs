using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class editBookForm : Form
    {
        public editBookForm()
        {
            InitializeComponent();
        }
        private Book book;
        private void searchBookButton_Click(object sender, EventArgs e)
        {
            if (ManageBooks.ListBooks.FirstOrDefault(item => item.Title.ToLower() == findBookTitle.Text.ToLower()) != null)
            {
                book = ManageBooks.ListBooks.FirstOrDefault(item => item.Title.ToLower() == findBookTitle.Text.ToLower());
                bookTitle.Text = book.Title;
                authorName.Text = book.AuthorName;
                price.Text = book.BuyingPrice.ToString();
                readStatus.Checked = book.ReadStatus;
            }
            else
            {
                MessageBox.Show($"Not Found Book Named {findBookTitle.Text}");
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Book newBook = new Book(bookTitle.Text, authorName.Text, double.Parse(price.Text), readStatus.Checked);
            ManageBooks.EditBook(book, newBook);
            Close();
        }
    }
}
