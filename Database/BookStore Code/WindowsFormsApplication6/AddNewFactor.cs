using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;

namespace WindowsFormsApplication6
{
    public partial class AddNewFactor : Form
    {
        public static int o;
        public AddNewFactor()
        {
            InitializeComponent();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            o = 0;

            string mydate = DateTime.Now.ToString("yyyy/MM/dd");
            textBox3.Text = mydate;

            string mytime = DateTime.Now.ToString("HH:mm:ss");
            textBox4.Text = mytime;

             string factor_id = DateTime.Now.ToString("yyMMdd" + "HHmmss");
            textBox1.Text = factor_id;
            


        }
        int y = 0;

        private void button2_Click(object sender, EventArgs e)
        {



            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=BookStore;Integrated Security=True");
            con.Open();
            DataAccess DA1 = new DataAccess();
            DataTable DT3 = new DataTable();

           

            String useri = "SELECT customer_id FROM [dbo].[Customer] where customer_id=" + textBox2.Text;
            DT3 = DA1.read(useri);
            if (DT3.Rows.Count == 0)
            {
                
                MessageBox.Show("No user with that id exists! ");
            }
            else
            {

              
                int book_id = Convert.ToInt32(dataGridView1.Rows[o].Cells[0].Value);

                DataAccess da = new DataAccess();
                DataTable dt = new DataTable();

                String qu = "Select Book.book_id, bookname, price, book_number FROM Book JOIN OrderList on Book.book_id = OrderList.book_id WHERE Book.book_id =" + book_id;
                dt = da.read(qu);
                dataGridView1.Rows.Add();
                SqlCommand com = new SqlCommand(qu, con);
                com.ExecuteNonQuery();
               
                dataGridView1.Rows[o].Cells[1].Value = dt.Rows[0][0];
                // int p1 = Convert.ToInt32(dt.Rows[o][0]);
                dataGridView1.Rows[o].Cells[2].Value = dt.Rows[0][1];
                int p2 = Convert.ToInt32(dt.Rows[0][1]);
                int p3 = Convert.ToInt32(dataGridView1.Rows[o].Cells[3].Value);
                dataGridView1.Rows[o].Cells[4].Value = p3 * p2;


                int x = Convert.ToInt32(dataGridView1.Rows[o].Cells[4].Value); 

                y += x;
                textBox5.Text = y.ToString();
                SqlConnection con1 = new SqlConnection("Data Source=.;Initial Catalog=BookStore;Integrated Security=True");
                con1.Open();

                DataAccess DA3 = new DataAccess();
                DataTable DT31 = new DataTable();
                string getqt = "select Qty from Book where book_id = " + book_id;
                SqlCommand com2 = new SqlCommand(getqt, con);
                com2.ExecuteNonQuery();

                DT31 = DA3.read(getqt);

                int qt31 = Convert.ToInt32(DT31.Rows[0][0]);

                

                int qtmi = qt31 - p3;

                string qtymi = " update Book set Qty ="+qtmi +" where book_id = "+book_id;
                SqlCommand com1 = new SqlCommand(qtymi, con);
                com1.ExecuteNonQuery();

                o++;



                int off = Convert.ToInt32(textBox6.Text);
                if (off < 100 && off>-1)
                {
                    double di = (100.00 - off) * y;


                    double due = di / 100.00;
                    Console.WriteLine(due);
                    textBox7.Text = due.ToString();
                }
                else { MessageBox.Show("Invalid off value"); }



            }
            
            
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)  //save
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=BookStore;Integrated Security=True");
            con.Open();
            int i = dataGridView1.Rows.Count;
            for(int j=0;j<i-2;j++)
            {
                int bid = Convert.ToInt32(dataGridView1.Rows[j].Cells[0].Value);
                int num = Convert.ToInt32(dataGridView1.Rows[j].Cells[3].Value);
                string book_id = textBox1.Text;
                
                String insord = "INSERT INTO dbo.OrderList(factor_id,book_id,book_number) VALUES ('" + book_id + "'," + bid + ", " + num + ")";
                SqlCommand com4 = new SqlCommand(insord, con);
                com4.ExecuteNonQuery();
            }
         
            
             String insfactor = "INSERT INTO dbo.Factor(factor_id, customer_id, total_price, pyment_price, discountpercent, factor_data, factor_time) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox5.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + textBox3.Text + "','" + textBox4.Text + "' )";
               SqlCommand com = new SqlCommand(insfactor, con);
                com.ExecuteNonQuery();
                
            
           
                    MessageBox.Show("done!");
            




            con.Close();

            AddNewFactor.ActiveForm.Close();

        }

        private void Search_Click(object sender, EventArgs e)
        {
            DataAccess DA4 = new DataAccess();
            DataTable DT4 = new DataTable();
            String usern = ("SELECT* FROM[dbo].[Customer] WHERE customername ='" + textBox8.Text + "'");

            DT4 = DA4.read(usern);
            dataGridView2.DataSource = DT4;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
