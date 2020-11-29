using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    class DataAccess
    {
        string connectionString = @"Data Source=.;Initial Catalog=BookStore ;Integrated Security=True";

        public void insert(string SQL)
        {
            SqlConnection Con = new SqlConnection(connectionString);
            string commandText = SQL;
            SqlCommand Cmd = new SqlCommand(commandText, Con);
            Con.Open();
            Cmd.ExecuteNonQuery();
            Con.Close();
        }

        public DataTable read(String SQL)
        {
            DataTable DT = new DataTable();

            try
            {
                SqlConnection Con = new SqlConnection(connectionString);
                SqlDataAdapter DA = new SqlDataAdapter();
                DA.SelectCommand = new SqlCommand(SQL, Con);
                Con.Open();
                DA.Fill(DT);
                Con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return DT;
        }

        public void update(string SQL)
        {
           
            SqlConnection Con = new SqlConnection(connectionString);
            string commandText = SQL;
            SqlCommand Cmd = new SqlCommand(commandText, Con);
            Con.Open();
            Cmd.ExecuteNonQuery();
            Con.Close();
        }
    }
}
