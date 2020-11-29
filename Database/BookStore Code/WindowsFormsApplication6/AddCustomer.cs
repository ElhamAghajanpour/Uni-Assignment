using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.Data.SqlClient;

namespace WindowsFormsApplication6
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
                    }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string t1 = textBox1.Text; //customername
            string t2 = textBox2.Text; //customer_id
            string t3 = textBox3.Text; //phone_number
            string t4 = textBox4.Text; //age

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=BookStore;Integrated Security=True");
            con.Open();
            try
            {
            String query = "INSERT INTO dbo.Customer(customername,customer_id,phone_number,age) VALUES ('"+ t1+"','"+t2+"','"+t3+"','"+t4+"')" ;
            SqlCommand com = new SqlCommand(query,con);
            

                com.ExecuteNonQuery();
                MessageBox.Show("done!");
            }
            catch ( SqlException ex){
                if (ex.Number == 2627)
                {
                    MessageBox.Show("U entered iterative id! ");
                }
                else {
                    MessageBox.Show("done!");
                }

            } 

            con.Close();
         
            AddCustomer.ActiveForm.Close();
            

           

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
