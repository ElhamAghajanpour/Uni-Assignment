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
    public partial class FactorList : Form
    {
        public FactorList()
        {
            InitializeComponent();
        }

        private void FactorList_Load(object sender, EventArgs e)
        {
            DataAccess DA = new DataAccess();
            DataTable DT = new DataTable();
            
            DT = DA.read("SELECT * FROM [dbo].[Factor]");
            dataGridView1.DataSource = DT;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
