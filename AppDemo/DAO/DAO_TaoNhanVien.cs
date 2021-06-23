using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using Connecter_Tier;
using System.Data;
namespace DAO
{
    public class DAO_TaoNhanVien
    {
        private CSDL_sellPhone_mainEntities _sellPhone_mainEntities = new CSDL_sellPhone_mainEntities();
        private DP _DP = new DP();

        public List<DTO_staff> LayDanhSachNhanVien()
        {
            List<DTO_staff> _lstDTO_staff = new List<DTO_staff>();
           return _sellPhone_mainEntities.STAFF.Where(h => h.staStatus ==1).Select(n => new DTO_staff {staID = n.staID, staName = n.staName ,staBirthday = n.staBirthday.Value , staAddress = n.staAddress, staPhone = n.staPhone , staSex = n.staSex.Value, staDescription = n.staDescription , staStatus = n.staStatus.Value ,staSalary = n.staSalary.Value ,staPosition = n.staPosition ,LoginID = n.LoginID.Value}).ToList();
        }
        public  int LayID(string user)
        {
            int ID = -1;
            SqlConnection _con = _DP.connection_DB();
            string sql = "SELECT LoginID  FROM Staff_Login where LoginUserName =@userNew";
            List<SqlParameter> lstPara = new List<SqlParameter>();
            lstPara.Add(new SqlParameter("@userNew", user));

            SqlDataReader sdr = _DP.run_query_select(sql, lstPara, _con);
            if (sdr.HasRows)
            {
                sdr.Read();
                 ID = sdr.GetInt32(0);
            }

            _DP.Close_connection_DB(_con);
            return ID;
        }
        public int LayIDMax(string NameCol, string table)
        {
            SqlConnection _con = _DP.connection_DB();
            string sql = "SELECT  MAX("+NameCol+ ") FROM  " + table;

            SqlCommand cmd = new SqlCommand(sql, _con);
            SqlDataReader sdr = cmd.ExecuteReader();
            int ID = 0;
            if (sdr.HasRows)
            {
                sdr.Read();
                ID = sdr.GetInt32(0);
            }

            _DP.Close_connection_DB(_con);
            return ID;
        }
        public bool ThemNhanVienLogin( DTO_staffLogin staffLogin)
        {
            int tam1 = _sellPhone_mainEntities.ThemNhanVienLogin(staffLogin.LoginUserName, staffLogin.LoginPassword);
            _sellPhone_mainEntities.SaveChanges();
            return tam1 > 0;
        }
        public bool ThemNhanVien(DTO_staff staff )
        {
            int tam1 = _sellPhone_mainEntities.ThemNhanVien(staff.staName, staff.staBirthday, staff.staAddress, staff.staPhone, staff.staSex, staff.staDescription, 1, staff.staSalary, staff.staPosition, staff.LoginID);
            _sellPhone_mainEntities.SaveChanges();
            return tam1 > 0;
        }
        public bool XoaNhanVien(int id)
        {
            try
            {
                STAFF staff = _sellPhone_mainEntities.STAFF.SingleOrDefault(u => u.staID == id && u.staStatus == 1);
                staff.staStatus = 0;

                _sellPhone_mainEntities.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool SuaNhanVien(DTO_staff _DTO_staff)
        {
            try
            {
                STAFF staff = _sellPhone_mainEntities.STAFF.SingleOrDefault(u => u.staID == _DTO_staff.staID && u.staStatus == 1);
               
                staff.staName = _DTO_staff.staName;
                staff.staBirthday = _DTO_staff.staBirthday;
                staff.staAddress = _DTO_staff.staAddress;
                //staff.staImg = _DTO_staff.staImg;
                staff.staPhone = _DTO_staff.staPhone;
                staff.staSex = _DTO_staff.staSex;
                staff.staDescription = _DTO_staff.staDescription;
                staff.staStatus = _DTO_staff.staStatus;
                staff.staSalary = _DTO_staff.staSalary;
                staff.staPosition = _DTO_staff.staPosition;

                _sellPhone_mainEntities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }


    }
}
