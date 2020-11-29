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
    public partial class userlist : Form
    {
        public userlist()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
