using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
     public class BUS_DanhSachNhanVien
     {
        private DAO_DanhSachNhanVien _DAO_DanhSachNhanVien = new DAO_DanhSachNhanVien();
        public List<DTO_staff> TimNhanVienTheoTen(String ten)
        {
            return _DAO_DanhSachNhanVien.TimNhanVienTheoTen(ten);
        }
        public List<DTO_staff> TimNhanVienTheoID(int id)
        {
            return _DAO_DanhSachNhanVien.TimNhanVienTheoID(id);
        }
        public List<DTO_staff> TimNhanVienTheoDiaCHi(String diaChi)
        {
            return _DAO_DanhSachNhanVien.TimNhanVienTheoDiaCHi(diaChi);
        }
        public List<DTO_staff> TimNhanVienTheoSoDienThoai(String soDt)
        {
            return _DAO_DanhSachNhanVien.TimNhanVienTheoSoDienThoai(soDt);
        }
        public List<DTO_staff> TimNhanVienTheoVitri(String viTri)
        {
            return _DAO_DanhSachNhanVien.TimNhanVienTheoVitri(viTri);
        }
    }
}
