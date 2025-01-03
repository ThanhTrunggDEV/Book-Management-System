﻿using System;
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
    public partial class addBookForm : Form
    {
        public addBookForm()
        {
            InitializeComponent();
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {

            if (bookTitleTextBox.Text != string.Empty && authorNameTextBox.Text != string.Empty && priceTextBox.Text != string.Empty)
            {
                ManageBooks.AddBook(new Book(bookTitleTextBox.Text, authorNameTextBox.Text, double.Parse(priceTextBox.Text), double.Parse(originalPriceTextBook.Text), readOrNot.Checked));
                MessageBox.Show("Successfully");
                Close();
            }
            else
            {
                MessageBox.Show("Information Fields Cannot Be Blank");
            }
            
        }
    }
}
