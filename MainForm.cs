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
            ManageBooks test = new ManageBooks();
            LoginForm 
            foreach(var item in test.ListBooks)
            {
                Book b = item;
                //textBox1.Text = b.Title;
                listBox1.Items.Add($"{b.Title} | {b.AuthorName} | {b.ReadStatus} | {b.BuyingPrice}");
                listBox1.Items.Add("--------------------------------------------------------------");
            }
        }
    }
}
