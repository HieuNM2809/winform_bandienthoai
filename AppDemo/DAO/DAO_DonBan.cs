using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Connecter_Tier;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_DonBan
    {
        private CSDL_sellPhone_mainEntities _SellPhone_MainEntities = new CSDL_sellPhone_mainEntities();
        private DP db = new DP();
        public  List<DTO_staff> LayThongTinNVTheoLoginID(int id)
        {
            return _SellPhone_MainEntities.STAFF.Where(h => h.LoginID == id).Select(n => new DTO_staff { staID = n.staID, staName = n.staName, staBirthday = n.staBirthday.Value, staAddress = n.staAddress, staPhone = n.staPhone, staSex = n.staSex.Value, staDescription = n.staDescription, staStatus = n.staStatus.Value, staSalary = n.staSalary.Value, staPosition = n.staPosition, LoginID = n.LoginID.Value }).ToList();
        }
        public List<DTO_client> LayDanhSachKhachHang()
        {
            return _SellPhone_MainEntities.CLIENT.Where(h => h.cliStatus == 1).Select(n => new DTO_client { cliID = n.cliID, cliName = n.cliName, cliAddress = n.cliAddress, cliCountry = n.cliCountry , cliPhone = n.cliPhone, cliStatus = n.cliStatus.Value ,cliPostOfficeCode = n.cliPostOfficeCode }).ToList();
        }


        public List<DTO_client> TimKHTheoID(String id)
        {
             int ID = Convert.ToInt32(id);
            return 
                _SellPhone_MainEntities.CLIENT.Where(u => u.cliID == ID)
                .Select( v => new DTO_client { 
                  cliID = v.cliID,
                  cliName =v.cliName,
                  cliAddress = v.cliAddress,
                  cliCountry = v.cliCountry,
                  cliPhone = v.cliPhone,
                  cliPostOfficeCode = v.cliPostOfficeCode,
                  cliStatus  = v.cliStatus.Value
                
                }).ToList();
        }
        public List<DTO_client> TimKHTheoTenGanDung(String ten)
        {
            SqlConnection con = db.connection_DB();
            String query = "select cliID, cliName, cliAddress, cliCountry, cliPhone," +
             " cliPostOfficeCode   from CLIENT " +
             "where cliName like N'%" + ten + "%' ";
            List<SqlParameter> lstPara = new List<SqlParameter>();
            lstPara.Add(new SqlParameter("@name", ten));
            SqlDataReader sdr = db.run_query_select(query, lstPara, con);

            List<DTO_client> lstCli = new List<DTO_client>();
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    DTO_client cli = new DTO_client();
                    cli.cliID = sdr.GetInt32(0);
                    cli.cliName = sdr.GetString(1);
                    cli.cliAddress = sdr.GetString(2);
                    cli.cliCountry = sdr.GetString(3);
                    cli.cliPhone = sdr.GetString(4);
                    cli.cliPostOfficeCode = sdr.GetString(5);

                    lstCli.Add(cli);
                }
            }
            db.Close_connection_DB(con);

            return lstCli;
        }
        public List<DTO_client> TimKHTheoSDTGanDung(String sdt)
        {
            SqlConnection con = db.connection_DB();
            String query = "select cliID, cliName, cliAddress, cliCountry, cliPhone," +
             " cliPostOfficeCode   from CLIENT " +
             "where cliPhone like N'%" + sdt + "%' ";
            List<SqlParameter> lstPara = new List<SqlParameter>();
            lstPara.Add(new SqlParameter("@name", sdt));
            SqlDataReader sdr = db.run_query_select(query, lstPara, con);

            List<DTO_client> lstCli = new List<DTO_client>();
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    DTO_client cli = new DTO_client();
                    cli.cliID = sdr.GetInt32(0);
                    cli.cliName = sdr.GetString(1);
                    cli.cliAddress = sdr.GetString(2);
                    cli.cliCountry = sdr.GetString(3);
                    cli.cliPhone = sdr.GetString(4);
                    cli.cliPostOfficeCode = sdr.GetString(5);

                    lstCli.Add(cli);
                }
            }
            db.Close_connection_DB(con);

            return lstCli;

        }


        public bool ThemOrderBan(DTO_order _Order)
        {
            int tam = _SellPhone_MainEntities.ThemOrderBan(_Order.ordDate, _Order.ordDescription, _Order.staID, _Order.cliID);
            _SellPhone_MainEntities.SaveChanges();
            return tam > 0;
        }
        public bool ThemInfoOrderBan(DTO_informationOrder _InfoOrder)
        {
            int tam = _SellPhone_MainEntities.ThemInfoOrderBan(_InfoOrder.ordID, _InfoOrder.prodID, _InfoOrder.infoOrderSl, _InfoOrder.infoOrderPrice);
            _SellPhone_MainEntities.SaveChanges();
            return true;
        }
        public bool CapNhatSoLuong( int id,int sl)
        {
            try
            {
                PRODUCT pro = _SellPhone_MainEntities.PRODUCT.SingleOrDefault(u => u.prodID == id);
                pro.prodSL = pro.prodSL - sl;

                _SellPhone_MainEntities.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

    }
}
