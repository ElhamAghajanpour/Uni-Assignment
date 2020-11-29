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
    public partial class panel : Form
    {
        public panel()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            AddCustomer f = new AddCustomer();
            f.Show();

        }

        private void button4_Click(object sender, EventArgs e)  
        {
            FactorList f = new FactorList();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BookList f10 = new BookList();
            f10.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            CustomerList f8 = new CustomerList();
            f8.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddNewFactor f3 = new AddNewFactor();
            f3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddBook f5 = new AddBook();
            f5.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
          
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Exit f5 = new Exit();
            f5.Show();

            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MaxSaleByName f5 = new MaxSaleByName();
            f5.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
;
            BookListbySearch f5 = new BookListbySearch();
            f5.Show();
        }


        private void button8_Click_1(object sender, EventArgs e)
        {
            CustomerListbySearch f9 = new CustomerListbySearch();
            f9.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MaxSale f9 = new MaxSale();
            f9.Show();
        }
    }
}
