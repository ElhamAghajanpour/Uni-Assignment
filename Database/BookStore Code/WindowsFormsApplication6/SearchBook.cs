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
    public partial class BookListbySearch : Form
    {
        public BookListbySearch()
        {
            InitializeComponent();
        }



        private void BookListbySearch_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=BookStore;Integrated Security=True");
            SqlCommand com3 = new SqlCommand("booklist", con);
            com3.CommandType = System.Data.CommandType.StoredProcedure;
            con.Open();
            DataTable DT = new DataTable();
            DT.Load(com3.ExecuteReader());
            dataGridView1.DataSource = DT;
            com3.ExecuteNonQuery();

            con.Close();



        }
        private void Search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=BookStore;Integrated Security=True");
            con.Open();

            DataAccess DA2 = new DataAccess();
            DataTable DT2 = new DataTable();
            DataAccess DA = new DataAccess();
            DataTable DT = new DataTable();

            DataAccess DA3 = new DataAccess();
            DataTable DT3 = new DataTable();

            String bookn = "SELECT book_id FROM [dbo].[Book] where bookname= '" + textBox1.Text + "'";
            DT3 = DA3.read(bookn);

            if (DT3.Rows.Count > 0)
            {
                int bi = Convert.ToInt32(DT3.Rows[0][0]);

                String bookinf = "SELECT * FROM [dbo].[Book] where book_id=" + bi;
                DT2 = DA2.read(bookinf);
                dataGridView1.DataSource = DT2;

            }
            else { MessageBox.Show("No bookname exists. "); }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

