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
    public partial class MaxSale : Form
    {
        public MaxSale()
        {
            InitializeComponent();
        }

        private void ByType_Click(object sender, EventArgs e)
        {
            MaxSaleByType f9 = new MaxSaleByType();
            f9.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MaxSaleByName f = new MaxSaleByName();
            f.Show();
        }
    }
}
