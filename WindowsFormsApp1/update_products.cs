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
    public partial class update_products : Form
    {
        HomeForAdmin adm;
        public update_products(HomeForAdmin addm)
        {
            InitializeComponent();
            this.adm = addm;
        }

        public string conString = "Data Source=.;Initial Catalog=SuperMarket;Integrated Security=True";

        private void Sign_up_Click(object sender, EventArgs e)
        {
            string zz = adm.textBox4.Text.ToString();

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "Update dbo.Products Set Product_name = '" + first.Text.ToString() + "' , Brand_id = '" + last.Text.ToString() + "' , categorie_id = '" + phonne.Text.ToString() + "' , Product_modelYear = '" + st.Text.ToString() + "' , Product_price = '" + e_mail.Text.ToString() + "' , quantity = '"+ textBox1.Text.ToString()+ "' where Product_id = '" + zz + "' ";

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Done.");
            }
        }

        private void update_products_Load(object sender, EventArgs e)
        {

        }

        private void Product_id_Click(object sender, EventArgs e)
        {

        }

        private void Category_ID_Click(object sender, EventArgs e)
        {

        }

        private void Product_model_year_Click(object sender, EventArgs e)
        {

        }

        private void Product_price_Click(object sender, EventArgs e)
        {

        }

        private void Brand_ID_Click(object sender, EventArgs e)
        {

        }

        private void first_TextChanged(object sender, EventArgs e)
        {

        }

        private void phonne_TextChanged(object sender, EventArgs e)
        {

        }

        private void st_TextChanged(object sender, EventArgs e)
        {

        }

        private void e_mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void last_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
