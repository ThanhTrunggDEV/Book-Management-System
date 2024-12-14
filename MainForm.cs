using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void reloadListBook(object sender, EventArgs e)
        {
            bookTitleList.Items.Clear();
            authorNameList.Items.Clear();
            readStatusList.Items.Clear();
            priceList.Items.Clear();
            originalPriceList.Items.Clear();
            MainForm_Load(sender, e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            addBookForm add_Book = new addBookForm();
            add_Book.ShowDialog();
            reloadListBook(sender, e);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (var item in ManageBooks.ListBooks)
            {
                bookTitleList.Items.Add(item.Title);
                bookTitleList.Items.Add("------------------------------------------------------------------------------------------------------");
                authorNameList.Items.Add(item.AuthorName);
                authorNameList.Items.Add("-----------------------------------------------------------------------------------------------------");
                if (!item.ReadStatus)
                    readStatusList.Items.Add("Not Yet");
                else readStatusList.Items.Add("Already Read");
                readStatusList.Items.Add("---------------------------------------------------------------------------------------------");
                priceList.Items.Add(item.BuyingPrice + " VNĐ");
                priceList.Items.Add("-------------------------------------------------------------------------------------------");
                originalPriceList.Items.Add(item.OriginalPrice + " VND");
                originalPriceList.Items.Add("-------------------------------------------------------------------------------------------");
            }
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ManageBooks.SaveBooksToFile();
        }

        private void getTotalPrice_Click(object sender, EventArgs e)
        {
            ManageBooks.GetTotalPrice();
        }

        private void editBookButton_Click(object sender, EventArgs e)
        {
            editBookForm editBookForm = new editBookForm();
            editBookForm.ShowDialog();
            reloadListBook(sender, e);
        }
    }
}
