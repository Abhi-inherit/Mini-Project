using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DBHelper
    {

        public SqlCommand cmd;
        public SqlConnection con;

        public SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-I5Q4TKGM\\SQLEXPRESS;Initial Catalog=Buyit;Integrated Security=True");

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            con.Open();
            return con;
        }

        public int Check(string x, string y)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Admin WHERE Email= '" + x + "' AND Password= '" + y + "'", GetConnection());
            int Count = Convert.ToInt32(cmd.ExecuteScalar());
            return Count;
        }

    }
}
