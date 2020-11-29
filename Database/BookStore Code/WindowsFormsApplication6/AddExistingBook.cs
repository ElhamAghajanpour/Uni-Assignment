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
    public partial class AddExistingBook : Form
    {
        public AddExistingBook()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess DA = new DataAccess();
            DataTable DT = new DataTable();
            DataTable DT2 = new DataTable();
            

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=BookStore;Integrated Security=True");
            con.Open();

            int q1 = 0;
            int t1 =Convert.ToInt32(textBox1.Text);
            int t2 = Convert.ToInt32(textBox2.Text);


            String query2 ="SELECT Qty FROM [dbo].[Book] where book_id=" + t1;
            DT = DA.read(query2);


            if (DT.Rows.Count != 0)
            {
                 q1 = Convert.ToInt32(DT.Rows[0][0]);
            }

            int t = q1 + t2;
            String query3 = "select book_id  from dbo.Book where book_id= "+ t1;
            DT2 = DA.read(query3);
            if (DT2.Rows.Count == 0)
            {
                MessageBox.Show("No book with that id exists! ");
            }
            else
            {
            

                String query = "UPDATE [dbo].[Book] SET [Qty] ="+t+" WHERE book_id= "+t1;
                SqlCommand com = new SqlCommand(query, con);
                
                com.ExecuteNonQuery();
                MessageBox.Show("done!");
            }
           



            con.Close();



            AddExistingBook.ActiveForm.Close();
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
