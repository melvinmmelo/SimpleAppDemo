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
    public partial class Home : Form
    {

        User user = new User();
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            user.all();
            dataGridView1.DataSource = user.dt;

            // Changing DataGridView column names
            dataGridView1.Columns["ID"].HeaderText = "Student No.";
            dataGridView1.Columns["last_name"].HeaderText = "Last name";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Login flogin = new Login();
            flogin.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            user.search(tx_key.Text);
            dataGridView1.DataSource = user.dt;
        }
    }
}
