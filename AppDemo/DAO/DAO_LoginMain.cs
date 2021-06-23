using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace DAO
{
    public class DAO_LoginMain
    {
        private CSDL_sellPhone_mainEntities _sellPhoneEntities = new CSDL_sellPhone_mainEntities();

        /// <summary>
        /// kiểm tra thông tin có đúng hay k 
        /// </summary>
        /// <param name="user"> </param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public bool kiemTraLogin(String user, String pass)
        {

            //-------------------------  entity ghep bang
           // _sellPhoneEntities.STAFF.ToList()[0].STAFF_LOGIN.

            try
            {
                //STAFF_LOGIN tam = _sellPhoneEntities.STAFF_LOGIN.SingleOrDefault(u => u.LoginUserName == user && u.LoginPassword == pass);
                //if (tam != null)
                //{
                //    return true;
                //}
                //return false;

              int tam = _sellPhoneEntities.KiemTraLoginMain(user, pass).ToList()[0].Value;
              
              return tam>0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}


