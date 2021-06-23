using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class BUS_DonBan
    {
        private DAO_NhapHang _NhapHang = new DAO_NhapHang();
        private DAO_DonBan _DonBan = new DAO_DonBan();
        public List<DTO_staff> LayThongTinNVTheoLoginID(int id)
        {
            return _NhapHang.TimNhanVienTheoID(id);
        }
        public List<DTO_client> LayDanhSachKhachHang()
        {
            return _DonBan.LayDanhSachKhachHang();
        }
        public List<DTO_client> TimKHTheoID(String id)
        {
            return _DonBan.TimKHTheoID(id);
        }
        public List<DTO_client> TimKHTheoSDTGanDung(String sdt)
        {
            return _DonBan.TimKHTheoSDTGanDung(sdt);
        }
        public List<DTO_client> TimKHTheoTenGanDung(String ten)
        {
            return _DonBan.TimKHTheoTenGanDung(ten);
        }


        public bool ThemOrderBan(DTO_order _Order)
        {
            return _DonBan.ThemOrderBan(_Order);
        }
        public bool ThemInfoOrderBan(DTO_informationOrder _InfoOrder)
        {
            return _DonBan.ThemInfoOrderBan(_InfoOrder);
        }
        public bool CapNhatSoLuong(int id, int sl)
        {
            return _DonBan.CapNhatSoLuong(id, sl);
        }
    }
}
