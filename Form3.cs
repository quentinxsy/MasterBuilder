using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterBuilder
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // Setting up new password
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if(textBox1.Text != null)
                {
                    LoginForm.Password = textBox1.Text;
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    this.Hide();
                    MessageBox.Show("New Password Created: " + LoginForm.Password);
                }
                else
                {
                    MessageBox.Show("Password cannot be empty.");
                }
            }
        }
    }
}
