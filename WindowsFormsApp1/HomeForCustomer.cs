using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class HomeForCustomer : Form
    {
        customer c1;
        public HomeForCustomer(customer cc1)
        {
            InitializeComponent();
            this.c1 = cc1;
        }

        private void HomeForCustomer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UpdateCustomerInfo(c1).ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string x = c1.textBox1.Text.ToString();
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=SuperMarket;Integrated Security=True");
            conn.Open();

            SqlCommand sda = new SqlCommand("Delete From dbo.Customers where customer_user_name ='"+x+"'", conn);

            sda.ExecuteNonQuery();

            MessageBox.Show("Done!.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            show_products sp = new show_products();
            sp.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
