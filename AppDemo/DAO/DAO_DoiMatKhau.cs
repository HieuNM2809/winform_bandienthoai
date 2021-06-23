using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using Connecter_Tier;


namespace DAO
{
    public class DAO_DoiMatKhau
    {
        private CSDL_sellPhone_mainEntities _SellPhone_MainEntities = new CSDL_sellPhone_mainEntities();
        private DP _DP = new DP();

        /// <summary>
        /// Lưu mâth khẩu satff
        /// </summary>
        /// <param name="User">Tên đăng nhập</param>
        /// <param name="Pass">mật khẩu </param>
        /// <returns>đúng trả về 1 , sai thì 0</returns>
        public bool LuuMatKhau(String User,String Pass, String UserNew, String PassNew)
        {


            // kiem tra xem trong database co ten nay chua
            DTO_staffLogin staffLogin = new DTO_staffLogin();

            SqlConnection _con = _DP.connection_DB();

            string sql = "SELECT LoginUserName,LoginPassword  FROM Staff_Login where LoginUserName =@userNew";
            List<SqlParameter> lstPara = new List<SqlParameter>();
            lstPara.Add(new SqlParameter("@userNew", UserNew));
            lstPara.Add(new SqlParameter("@passNew", PassNew));

            SqlDataReader sdr = _DP.run_query_select(sql, lstPara, _con);

           
            if (sdr.HasRows)
            {
                sdr.Read();
                staffLogin.LoginUserName = sdr.GetString(0);
                staffLogin.LoginPassword = sdr.GetString(1);
            }

            _DP.Close_connection_DB(_con);

            if (String.IsNullOrEmpty(staffLogin.LoginUserName))
            {
                int tam = _SellPhone_MainEntities.CapNhatTaiKhoan(User, Pass, UserNew, PassNew);
                _SellPhone_MainEntities.SaveChanges();
                if (tam == 1)
                    return true;
                return false;
            }
            return false;
        }
    }
}
