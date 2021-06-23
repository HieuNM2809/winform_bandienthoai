using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public  class DAO_KhachHang
    {
        private CSDL_sellPhone_mainEntities _SellPhone_MainEntities = new CSDL_sellPhone_mainEntities();

        public bool ThemKhachHang(DTO_client _Client)
        {
            int tamp =  _SellPhone_MainEntities.ThemKhachHang(_Client.cliName, _Client.cliAddress, _Client.cliCountry, _Client.cliPostOfficeCode, _Client.cliPhone);
            return tamp > 0;
        }
    }
}
