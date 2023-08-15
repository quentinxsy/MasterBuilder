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
    public partial class LoginForm : Form
    {
        public static string Password = "GGEZ";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PasswordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Simulate a button click
                button1.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if password is correct, if so go to set up page
            if (PasswordBox.Text == Password)
            {
                Form2 nextForm = new Form2();
                nextForm.Show();
                this.Hide();
            }
            else
            {
                // Message
                MessageBox.Show("Incorrect password!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check, if so go to change password page
            if (PasswordBox.Text == Password)
            {
                Form3 nextForm = new Form3();
                nextForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect password!");
            }
        }
    }
}
