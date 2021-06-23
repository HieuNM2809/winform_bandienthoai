using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
     public class BUS_Navigation
    {
        private DAO_Navigation _DAO_Navigation = new DAO_Navigation();
        public DTO_staff LayTenVaViTri(String user)
        {
            return _DAO_Navigation.LayTenVaViTri(user);
        }
    }
}
