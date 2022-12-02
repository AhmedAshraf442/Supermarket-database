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
    public partial class show_products : Form
    {
        public string conString = "Data Source=.;Initial Catalog=SuperMarket;Integrated Security=True";
        public show_products()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(conString) ;
            con.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("Select * From dbo.Products" , con);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void show_products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'superMarketDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.superMarketDataSet.Products);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
