using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace library
{
    internal class DataBase
    {
SqlConnection sqlc = new SqlConnection();
        SqlCommand sqlcm = new SqlCommand();
        public DataTable Select(string str)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();  
            sqlc.ConnectionString = "Data Source=localhost\\SAROJAFARII;Initial Catalog=library;Integrated Security=True";
            sqlc.Open();
            sqlcm.Connection = sqlc;
            sqlcm.CommandText = str;
            adapter.SelectCommand = sqlcm;
            adapter.Fill(dt);
            sqlc.Close();
            return dt;
        }
        public bool Exe(string str)
        {
            sqlc.ConnectionString = "Data Source=localhost\\SAROJAFARII;Initial Catalog=library;Integrated Security=True";
     sqlc.Open();
            sqlcm.Connection = sqlc;
            sqlcm.CommandText=str;
            try { 
            sqlcm.ExecuteNonQuery();
                return true;
            }
            catch {
            
            return false;
                    }
            finally
            {
                sqlc.Close();
            }
       }
    }
}
