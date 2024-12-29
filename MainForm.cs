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
        private Book oldBook;
        private Book newBook;
        public MainForm()
        {
            InitializeComponent();
        }
        private void reloadListBook(object sender, EventArgs e)
        {
            lvBooks.Items.Clear();
            MainForm_Load(sender, e);
        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            addBookForm add_Book = new addBookForm();
            add_Book.ShowDialog();
            reloadListBook(sender, e);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            int order = 1;
            tsLbl_OriginalPrice.Text = $"Total Original Price: {ManageBooks.GetTotalOriginalPrice()} VNĐ";
            tsLbl_BuyingPrice.Text = $"Total Buying Price: {ManageBooks.GetTotalBuyingPrice()} VNĐ";
            foreach (var item in ManageBooks.ListBooks)
            {
                ListViewItem listViewItem = new ListViewItem(order.ToString());
                listViewItem.SubItems.Add(item.Title);
                listViewItem.SubItems.Add(item.AuthorName);
                listViewItem.SubItems.Add(item.ReadStatus ? "Already Read" : "Not Yet");
                listViewItem.SubItems.Add(item.BuyingPrice.ToString());
                listViewItem.SubItems.Add(item.OriginalPrice.ToString());
                
                lvBooks.Items.Add(listViewItem);
                order++;
            }
            
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ManageBooks.SaveBooksToFile();
        }

        private void editBookButton_Click(object sender, EventArgs e)
        {
            Form frmEditBook = new Form();
            frmEditBook.StartPosition = FormStartPosition.CenterParent;
            TextBox txtTitle = new TextBox();
            txtTitle.Text = lvBooks.SelectedItems[0].SubItems[1].Text;
            
            frmEditBook.Controls.Add(txtTitle);
            frmEditBook.ShowDialog();
            reloadListBook(sender, e);
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            string time = "" +
                "                                                                         " 
                + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            tsLblDateTime.Text = time;
        }

        private void tsBtn_Del_Click(object sender, EventArgs e)
        {
            if(lvBooks.SelectedItems.Count > 0)
            {
                var book = ManageBooks.ListBooks.FirstOrDefault(item => item.Title == lvBooks.SelectedItems[0].SubItems[1].Text);
                if (book != null)
                {
                    var result = MessageBox.Show("Are You Sure?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        ManageBooks.RemoveBook(book);
                        reloadListBook(sender, e);
                    }

                }
                else
                {
                    MessageBox.Show("Not Found");
                }
            }
            else
            {
                MessageBox.Show("Please Select A Book To Delete");
            }
        }

        private void lvBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvBooks.SelectedItems.Count > 0)
            {
                if(tsCbbOption.Text == "Title")
                {
                    tsTb.Text = lvBooks.SelectedItems[0].SubItems[1].Text;
                }
                if(tsCbbOption.Text == "Author")
                {
                    tsTb.Text = lvBooks.SelectedItems[0].SubItems[2].Text;
                }
                if(tsCbbOption.Text == "Status")
                {
                    tsTb.Text = lvBooks.SelectedItems[0].SubItems[3].Text;
                }
                if (tsCbbOption.Text == "Buying Price")
                {
                    tsTb.Text = lvBooks.SelectedItems[0].SubItems[4].Text;
                }
                if (tsCbbOption.Text == "Original Price")
                {
                    tsTb.Text = lvBooks.SelectedItems[0].SubItems[5].Text;
                }
            }
           
        }

        private void tsCbbOption_TextChanged(object sender, EventArgs e)
        {
            lvBooks_SelectedIndexChanged(sender, e);
        }

        private void tsBtn_Edit_Click(object sender, EventArgs e)
        {
            oldBook = ManageBooks.ListBooks[lvBooks.SelectedItems[0].Index];
            string title = oldBook.Title;
            string author = oldBook.AuthorName;
            string status = lvBooks.SelectedItems[0].SubItems[3].Text;
            double buyingPrice = oldBook.BuyingPrice;
            double originalPrice = oldBook.OriginalPrice;
            if(tsCbbOption.Text == "Title")
            {
                title = tsTb.Text;
            }
            if(tsCbbOption.Text == "Author")
            {
                author = tsTb.Text;
            }
            if (tsCbbOption.Text == "Status")
            {
                status = tsTb.Text;
            }
            if (tsCbbOption.Text == "Buying Price")
            {
                buyingPrice = double.Parse(tsTb.Text);
            }
            if (tsCbbOption.Text == "Original Price")
            {
                originalPrice = double.Parse(tsTb.Text);
            }
            newBook = new Book(title, author, buyingPrice, originalPrice, status == "Already Read" ? true : false);
            ManageBooks.EditBook(oldBook, newBook);
            reloadListBook(sender, e);
        }
    }
}
