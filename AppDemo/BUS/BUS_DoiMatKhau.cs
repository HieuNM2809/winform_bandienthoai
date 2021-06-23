using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class BUS_DoiMatKhau
    {
        private DAO_DoiMatKhau _DAO_DoiMatKhau = new DAO_DoiMatKhau();
        public bool LuuMatKhau(String User , String Pass,String UserNew, String PassNew)
        {
            return _DAO_DoiMatKhau.LuuMatKhau(User,Pass, UserNew,PassNew);
        }
    }
}
