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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(usernameTextbox.Text == "Trung1506" && passwordTextbox.Text == "trung1506")
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("User Name Or Password is wrong");
            }
            
        }
    }
}
