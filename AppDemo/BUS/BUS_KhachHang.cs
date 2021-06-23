using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class BUS_KhachHang
    {
        private DAO_KhachHang _KhachHang = new DAO_KhachHang();
        public bool ThemKhachHang(DTO_client _Client)
        {
            return _KhachHang.ThemKhachHang(_Client);
        }
    }
}
