using System;
using System.Collections;
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
            System.GC.Collect();
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-I5Q4TKGM\\SQLEXPRESS;Initial Catalog=Buyit;Integrated Security=True");

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            con.Open();
            return con;
        }

        public int GetID(string id, string table, string Catname, string catValue) 
        {
            SqlCommand cmd = new SqlCommand("select " + id + " from " + table + " where " + Catname + " = '" + catValue + "' ", GetConnection());
            int Count = Convert.ToInt32(cmd.ExecuteScalar());
            return Count;
        }

        public string ExecuteProcedure(SortedList list, string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, GetConnection());
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                if (!(list.Count == 0))
                {
                    string[] mKeys = new string[list.Count];
                    list.Keys.CopyTo(mKeys, 0);
                    int i = 0;
                    for (i = 1; i <= list.Count; i++)
                    {
                        cmd.Parameters.Add(new SqlParameter("@" + mKeys[i - 1], list[mKeys[i - 1]]));

                    }
                }
                string x;
                return x = cmd.ExecuteScalar().ToString();
            }
            catch (Exception)
            {
                return "-1";
            }
            finally
            {
                if (GetConnection().State == ConnectionState.Open)
                {
                    GetConnection().Close();
                }
            }
        }


        public DataTable getdatatable(string query)
        {

            SqlDataAdapter ad = new SqlDataAdapter(query, GetConnection());
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        public DataTable getdatatable(SortedList list, string query)
        {


            SqlCommand cmd = new SqlCommand(query, GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            if (!(list.Count == 0))
            {
                string[] mKeys = new string[list.Count];
                list.Keys.CopyTo(mKeys, 0);
                int i = 0;
                for (i = 1; i <= list.Count; i++)
                {
                    cmd.Parameters.Add(new SqlParameter("@" + mKeys[i - 1], list[mKeys[i - 1]]));
                }
            }

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;



        }

        public object execscalar(string query)
        {

            SqlCommand cmd = new SqlCommand(query, GetConnection());
            object s;
            s = cmd.ExecuteScalar();
            return s;
        }
        public int execquery(string query)
        {

            SqlCommand cmd = new SqlCommand(query, GetConnection());
            return cmd.ExecuteNonQuery();
        }

    }
}
