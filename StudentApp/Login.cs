using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Form1 rform = new Form1();
            rform.Show();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(tx_uname.Text) || String.IsNullOrEmpty(tx_pass.Text))
            {
                MessageBox.Show("All fields are required.", "You've got an error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User user = new User();
            var res = user.login(tx_uname.Text, tx_pass.Text);
            if (res)
            {
                Hide();
                Home home = new Home();
                home.Show();
            }
            else
            {
                MessageBox.Show("No account found.", "You've got an error.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
