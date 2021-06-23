using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Connecter_Tier
{
    public class DP
    {
        public SqlConnection connection_DB()
        {
            String _connectionString = @"Data Source=LAPTOP-69UU6VD7\SQLEXPRESS;Initial Catalog=CSDL_sellPhone_main;Integrated Security=True";
            try
            {
                SqlConnection _conn = new SqlConnection(_connectionString);
                _conn.Open();
                return _conn;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public bool Close_connection_DB(SqlConnection _conn)
        {
            if (_conn.State == ConnectionState.Open)
            {
                _conn.Close();
                return true;
            }
            return false;
        }
        public SqlDataReader run_query_select(String sql, List<SqlParameter> lstPara, SqlConnection _conn)
        {
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddRange(lstPara.ToArray());
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }
        public bool run_query(String sql, SqlConnection _conn)
        {
            SqlCommand cmd = new SqlCommand(sql, _conn);
            int x = cmd.ExecuteNonQuery();
            _conn.Close();
            return (x > 0);
        }
    }
}
