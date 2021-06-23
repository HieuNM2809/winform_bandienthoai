using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public  class BUS_TaoNhanVien
    {
        private DAO_TaoNhanVien _DAO_TaoNhanVien = new DAO_TaoNhanVien();
        public List<DTO_staff> LayDanhSachNhanVien()
        { 
            return _DAO_TaoNhanVien.LayDanhSachNhanVien();
        }
        public int LayID(string user)
        {
            return _DAO_TaoNhanVien.LayID(user);
        }
        public bool ThemNhanVienLogin( DTO_staffLogin staffLogin)
        {
            return _DAO_TaoNhanVien.ThemNhanVienLogin( staffLogin);
        }
        public bool ThemNhanVien(DTO_staff staff)
        {
            return _DAO_TaoNhanVien.ThemNhanVien(staff);
        }
        public bool XoaNhanVien(int id)
        {
            return _DAO_TaoNhanVien.XoaNhanVien(id);
        }
        public bool SuaNhanVien(DTO_staff _DTO_staff)
        {
            return _DAO_TaoNhanVien.SuaNhanVien(_DTO_staff);
        }
        public int LayIDMax(string NameCol, string table)
        {
            return _DAO_TaoNhanVien.LayIDMax(NameCol, table);
        }
    }
}
