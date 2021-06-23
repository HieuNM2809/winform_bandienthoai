using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class BUS_DanhSachNCC
    {
        private DAO_DanhSachNCC _DAO_DanhSachNCC = new DAO_DanhSachNCC();
        public List<DTO_provided> LayDsanhSachNCC()
        {
            return _DAO_DanhSachNCC.LayDsanhSachNCC();
        }
        public List<DTO_provided> TimNCCTheoTen(String ten)
        {
            return _DAO_DanhSachNCC.TimNCCTheoTen(ten);
        }
        public List<DTO_provided> TimNCCTheoID(int id)
        {
            return _DAO_DanhSachNCC.TimNCCTheoID(id);
        }
        public List<DTO_provided> TimNCCTheoDiaCHi(String diaChi)
        {
             return _DAO_DanhSachNCC.TimNCCTheoDiaCHi(diaChi);
        }
        public List<DTO_provided> TimNCCTheoSoDienThoai(String sdt)
        {
            return _DAO_DanhSachNCC.TimNCCTheoSoDienThoai(sdt);
        }
        public List<DTO_provided> TimNCCTheoThanhPho(string thanhPho)
        {
            return _DAO_DanhSachNCC.TimNCCTheoThanhPho(thanhPho);
        }
    }
}
