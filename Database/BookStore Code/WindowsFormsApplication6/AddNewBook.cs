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
    public partial class AddNewBook : Form
    {
        public AddNewBook()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t1 = textBox1.Text; //bookname
            string t2 = textBox2.Text;  //book_id
            string t3 = comboBox1.Text;  //booktype_id
            string t4 = textBox3.Text;  //price
            string t5 = comboBox2.Text;  //book_language
            string t6 = textBox7.Text;  //publisher
            string t7 = textBox8.Text;  //agecategory
            string t8 = textBox5.Text;    //Qty

if (t1 == "" || t2 == "" )

            {
                MessageBox.Show("Please fill empty fields. ");
            }
            else
            {


                double price = 0;
                double.TryParse(t4, out price);
                if (price == 0 || price < 0) { MessageBox.Show("price you entered contains character or it is negative or that's empty!"); }
                else
                {
                    double checkqty = 0;
                    double.TryParse(t8, out checkqty);
                    if (checkqty == 0 || checkqty < 0) { MessageBox.Show("Quantity you entered contains character or it is negative or that's empty!"); }

                    else
                    {


                        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=BookStore;Integrated Security=True");
                        con.Open();
                        try
                        {
                            String query = "INSERT INTO dbo.Book(bookname, book_id, booktype_id, price, book_language, publisher, agecategory, Qty) VALUES ('" + t1 + "','" + t2 + "','" + t3 + "','" + t4 + "','" + t5 + "','" + t6 + "', '" + t7 + "', '"+ t8 + "')";
                            SqlCommand com = new SqlCommand(query, con);

                            com.ExecuteNonQuery();
                            MessageBox.Show("done! ");
                        }
                        catch (SqlException ex)
                        {
                            if (ex.Number == 2627)
                            {
                                MessageBox.Show("iterative id ");
                            }
                            else
                            {
                                MessageBox.Show("done!");
                            }


                        }

                        con.Close();

                        AddNewBook.ActiveForm.Close();
                        AddBook.ActiveForm.Close();

                    }
                }
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
