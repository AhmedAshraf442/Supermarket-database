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
    public partial class Admin_update_customers : Form
    {
        HomeForAdmin admin;
        public Admin_update_customers(HomeForAdmin aadmin)
        {
            InitializeComponent();
            this.admin = aadmin;
        }

        public string conString = "Data Source=.;Initial Catalog=SuperMarket;Integrated Security=True";

        private void Update_Click(object sender, EventArgs e)
        {
            string zz = admin.textBox1.Text.ToString();

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "Update dbo.Customers Set customer_firstname = '" + first.Text.ToString() + "' , customer_lastname = '" + last.Text.ToString() + "' , customer_email = '" + e_mail.Text.ToString() + "' , customer_phone = '" + phonne.Text.ToString() + "' , customer_street = '" + st.Text.ToString() + "' , customer_city = '" + citty.Text.ToString() + "' , customer_state = '" + textBox7.Text.ToString() + "' , customer_zip_code = '" + zipCode.Text.ToString() + "' , customer_user_name = '" + useer.Text.ToString() + "' , customer_password = '" + textBox2.Text.ToString() + "'  where customer_id = '" + zz + "' ";

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Done.");
            }
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

        private void citty_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void zipCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void useer_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Admin_update_customers_Load(object sender, EventArgs e)
        {

        }

        private void intrroo_Click(object sender, EventArgs e)
        {

        }
    }
}
