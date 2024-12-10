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
        
        private void button1_Click(object sender, EventArgs e)
        {
            Add_Book_Form add_Book = new Add_Book_Form();
            add_Book.ShowDialog();
            bookTitleList.Items.Clear();
            authorNameList.Items.Clear();
            readStatusList.Items.Clear();
            priceList.Items.Clear();
            MainForm_Load(sender, e);
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
    }
}
