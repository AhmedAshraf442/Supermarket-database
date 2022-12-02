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
    public partial class HomeForAdmin : Form
    {
        public HomeForAdmin()
        {
            InitializeComponent();
        }

        private void HomeForAdmin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_update_customers uci = new Admin_update_customers(this);
            uci.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=SuperMarket;Integrated Security=True");
            conn.Open();

            SqlCommand sda = new SqlCommand("Delete From dbo.Customers where customer_id ='" + textBox2.Text.ToString() + "'", conn);

            sda.ExecuteNonQuery();

            MessageBox.Show("Done!.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            show_products sp = new show_products();
            sp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            update_products p = new update_products(this);
            p.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Add_new_products anp = new Add_new_products();
            anp.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=SuperMarket;Integrated Security=True");
            conn.Open();

            SqlCommand sda = new SqlCommand("Delete From dbo.Products where Product_id ='" + textBox3.Text.ToString() + "'", conn);

            sda.ExecuteNonQuery();

            MessageBox.Show("Done!.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
