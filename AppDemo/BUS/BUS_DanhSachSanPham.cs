using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class BUS_DanhSachSanPham
    {
        DAO_DanhSachSanPham _DAO_DanhSachSanPham = new DAO_DanhSachSanPham();
        public List<DTO_product> TimTheoTenGanDung(String ten)
        {
            return _DAO_DanhSachSanPham.TimTheoTenGanDung(ten);
        }
        public List<DTO_product> LayDanhSachSanPham()
        {
            return _DAO_DanhSachSanPham.LayDanhSachSanPham();
        }
        public List<DTO_provided> LayDanhSachNCC()
        {
            return _DAO_DanhSachSanPham.LayDanhSachNCC();
        }
        public List<DTO_product> TimTheoRam(String ram)
        {
            return _DAO_DanhSachSanPham.TimTheoRam(ram);
        }

        public List<DTO_product> TimTheoTen(String ten)
        {
            return _DAO_DanhSachSanPham.TimTheoTen(ten);
        }
        public List<DTO_product> TimTheoLoai(String loai)
        {
            return _DAO_DanhSachSanPham.TimTheoLoai(loai);
        }
        public List<DTO_product> TimTheoID(String id)
        {
            return _DAO_DanhSachSanPham.TimTheoID(id);
        }
        public List<DTO_product> TimTheoGia(String giaTu, String giaDen)
        {
            return _DAO_DanhSachSanPham.TimTheoGia(giaTu, giaDen);
        }
        public List<DTO_product> TimTheoNhaSX(int nhaSX)
        {
            return _DAO_DanhSachSanPham.TimTheoNhaSX(nhaSX);
        }
        public List<DTO_product> TimTheoNamSX(String namSX)
        {
            return _DAO_DanhSachSanPham.TimTheoNamSX(namSX);
        }
    }
}
