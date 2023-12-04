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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            DateTime current_date = DateTime.Now;
            string dateString = current_date.ToString("MM/dd/yyyy H:m ");

            // sample validation of password
            if (tx_password.Text != tx_confirm_pw.Text)
            {
                MessageBox.Show("Password not valid.");
                return;
            }

            // Other validations here
            // input validation 
            // email validation
            // gender validation
            // add your code here

            // create new instance of user
            User user = new User();

            // saving data in db
            // will return true if succeeded
            // data type boolean
            bool ifSuccess = user.save(tx_lname.Text, tx_fname.Text, tx_uname.Text, tx_gender.Text, tx_email.Text, tx_address.Text, tx_password.Text, dateString);

            if (ifSuccess)
            {
                MessageBox.Show("Registration success.");
            }
            else
            {
                MessageBox.Show("Failed. " + user.errMsg);
            }
        }
    }
}
