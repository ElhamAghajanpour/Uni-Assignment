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
    public partial class MaxSaleByName : Form
    {
        public MaxSaleByName()
        {
            InitializeComponent();
        }

        private void MaxSale_Load(object sender, EventArgs e)
        {

            DataAccess DA = new DataAccess();
            DataTable DT = new DataTable();
            
            DT = DA.read("SELECT Book.bookname, SUM(book_number) as SUM FROM Book JOIN OrderList on Book.book_id = OrderList.book_id GROUP BY(Book.bookname) ORDER BY SUM desc");
            dataGridView1.DataSource = DT;

            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
