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
    public partial class BookList : Form
    {
        public BookList()
        {
            InitializeComponent();
        }

        private void BookList_Load(object sender, EventArgs e)
        {
            DataAccess DA = new DataAccess();
            DataTable DT = new DataTable();
            DT = DA.read("SELECT * FROM [dbo].[Book]");
            dataGridView1.DataSource = DT;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
