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
    public partial class customers : Form
    {
        public customers()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=.;Initial Catalog=SuperMarket;Integrated Security=True";

        private void customers_Load(object sender, EventArgs e)
        {

        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
        

        private void fname_Click(object sender, EventArgs e)
        {

        }

        private void street_Click(object sender, EventArgs e)
        {

        }

        private void state_Click(object sender, EventArgs e)
        {

        }

        private void userr_Click(object sender, EventArgs e)
        {

        }

        

        private void pas_Click(object sender, EventArgs e)
        {

        }

        private void zip_Click(object sender, EventArgs e)
        {

        }

        private void city_Click(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
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

        private void useer_TextChanged(object sender, EventArgs e)
        {

        }

        private void last_TextChanged(object sender, EventArgs e)
        {

        }

        private void e_mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void citty_TextChanged(object sender, EventArgs e)
        {

        }

        private void zipCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sign_up_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into dbo.Customers (customer_firstname,customer_lastname,customer_phone,customer_email,customer_street,customer_city,customer_state,customer_zip_code,customer_user_name,customer_password)" +
                    "values ('" + first.Text.ToString() + "','" + last.Text.ToString() + "','" + phonne.Text.ToString() + "','" + e_mail.Text.ToString() + "','" + st.Text.ToString() + "','" + citty.Text.ToString() + "','" + textBox7.Text.ToString() + "','" + zipCode.Text.ToString() + "','" + useer.Text.ToString() + "','" + textBox2.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Done.");
            }
        }
    }
}
