using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class CustomerListbySearch : Form
    {
        public CustomerListbySearch()
        {
            InitializeComponent();
        }

        private void CustomerListbySearch_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=BookStore;Integrated Security=True");
            SqlCommand com = new SqlCommand("customerlist", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;
            con.Open();
            DataTable DT = new DataTable();
            DT.Load(com.ExecuteReader());
            dataGridView1.DataSource = DT;
            com.ExecuteNonQuery();

            con.Close();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            DataAccess DA4 = new DataAccess();
            DataTable DT4 = new DataTable();
            String usern = ("SELECT* FROM[dbo].[Customer] WHERE customername ='" + textBox1.Text + "'");

            DT4 = DA4.read(usern);
            dataGridView1.DataSource = DT4;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
