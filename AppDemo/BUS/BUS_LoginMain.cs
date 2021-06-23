using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{

    public class BUS_LoginMain
    {
        private DAO_LoginMain _DAO_LoginMain = new DAO_LoginMain();
        public bool kiemTraLogin(String user, String pass)
        {
           return  _DAO_LoginMain.kiemTraLogin(user, pass);
        }
    }
}
