using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class MaxSaleByType : Form
    {
        public MaxSaleByType()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void MaxSaleByType_Load(object sender, EventArgs e)
        {
            DataAccess DA = new DataAccess();
            DataTable DT = new DataTable();

            DT = DA.read("SELECT Book.booktype_id, SUM(book_number) as SUM  FROM Book JOIN OrderList on Book.book_id = OrderList.book_id GROUP BY(Book.booktype_id) OrDER BY SUM desc");
            dataGridView1.DataSource = DT;
        }
    }
}
