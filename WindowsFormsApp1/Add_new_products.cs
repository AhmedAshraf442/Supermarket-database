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
    public partial class Add_new_products : Form
    {
        public Add_new_products()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=.;Initial Catalog=SuperMarket;Integrated Security=True";

        private void Add_new_products_Load(object sender, EventArgs e)
        {

        }

        private void Sign_up_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "Insert into dbo.Products (Product_name,Brand_id,categorie_id,Product_modelYear,Product_price,quantity)" +
                    "values ('" + first.Text.ToString() + "','" + last.Text.ToString() + "','" + phonne.Text.ToString() + "','" + st.Text.ToString() + "','" + e_mail.Text.ToString() + "','"+ textBox1.Text.ToString()+ "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Done.");
            }
        }

        private void intrroo_Click(object sender, EventArgs e)
        {

        }

        private void Product_id_Click(object sender, EventArgs e)
        {

        }

        private void Brand_ID_Click(object sender, EventArgs e)
        {

        }

        private void Category_ID_Click(object sender, EventArgs e)
        {

        }

        private void Product_price_Click(object sender, EventArgs e)
        {

        }

        private void Product_model_year_Click(object sender, EventArgs e)
        {

        }

        private void first_TextChanged(object sender, EventArgs e)
        {

        }

        private void last_TextChanged(object sender, EventArgs e)
        {

        }

        private void phonne_TextChanged(object sender, EventArgs e)
        {

        }

        private void e_mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void st_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
