using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public  class DAO_Navigation
    {
        private CSDL_sellPhone_mainEntities _sellPhoneEntities = new CSDL_sellPhone_mainEntities();
        private static String _connectionString = @"Data Source=LAPTOP-69UU6VD7\SQLEXPRESS;Initial Catalog=CSDL_sellPhone_main;Integrated Security=True";
        private SqlConnection _conn = new SqlConnection(_connectionString);
        /// <summary>
        /// Lấy tên và vị trí 
        /// </summary>
        /// <param name="user">Tên đăng nhập</param>
        /// <returns>Nhân viên</returns>
        public DTO_staff LayTenVaViTri(String user)
        {
            DTO_staff staff = new DTO_staff();
            _conn.Open();

            string sql = "SELECT Staff.staName, staff.staPosition  FROM Staff,Staff_Login WHERE Staff.LoginID = Staff_Login.LoginID and STAFF_LOGIN.LoginUserName = @user";

            List<SqlParameter> lstPara = new List<SqlParameter>();
             // SqlParameter Para = new SqlParameter("@user",user);
            lstPara.Add(new SqlParameter("@user", user));

            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddRange(lstPara.ToArray());


            SqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.HasRows)
            {
                sdr.Read();
                staff.staName = sdr.GetString(0);
                staff.staPosition = sdr.GetString(1);
            }

            _conn.Close();
            return staff;
        }

    }
}
