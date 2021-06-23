using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Connecter_Tier;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class DAO_DanhSachNhanVien
    {
        private CSDL_sellPhone_mainEntities _sellPhone_mainEntities1 = new CSDL_sellPhone_mainEntities();
        public List<DTO_staff> TimNhanVienTheoTen(String ten)
        {
            List<DTO_staff> _lstDTO_staff = new List<DTO_staff>();
            return _sellPhone_mainEntities1.STAFF.Where(h => h.staName ==ten).Select(n => new DTO_staff { staID = n.staID, staName = n.staName, staBirthday = n.staBirthday.Value, staAddress = n.staAddress, staPhone = n.staPhone, staSex = n.staSex.Value, staDescription = n.staDescription, staStatus = n.staStatus.Value, staSalary = n.staSalary.Value, staPosition = n.staPosition, LoginID = n.LoginID.Value }).ToList();
        }
        public List<DTO_staff> TimNhanVienTheoID(int id)
        {
            List<DTO_staff> _lstDTO_staff = new List<DTO_staff>();
            return _sellPhone_mainEntities1.STAFF.Where(h => h.staID == id).Select(n => new DTO_staff { staID = n.staID, staName = n.staName, staBirthday = n.staBirthday.Value, staAddress = n.staAddress, staPhone = n.staPhone, staSex = n.staSex.Value, staDescription = n.staDescription, staStatus = n.staStatus.Value, staSalary = n.staSalary.Value, staPosition = n.staPosition, LoginID = n.LoginID.Value }).ToList();
        }
        public List<DTO_staff> TimNhanVienTheoDiaCHi(String diaChi)
        {
            List<DTO_staff> _lstDTO_staff = new List<DTO_staff>();
            return _sellPhone_mainEntities1.STAFF.Where(h => h.staAddress == diaChi).Select(n => new DTO_staff { staID = n.staID, staName = n.staName, staBirthday = n.staBirthday.Value, staAddress = n.staAddress, staPhone = n.staPhone, staSex = n.staSex.Value, staDescription = n.staDescription, staStatus = n.staStatus.Value, staSalary = n.staSalary.Value, staPosition = n.staPosition, LoginID = n.LoginID.Value }).ToList();
        }
        public List<DTO_staff> TimNhanVienTheoSoDienThoai(String sdt)
        {
            List<DTO_staff> _lstDTO_staff = new List<DTO_staff>();
            return _sellPhone_mainEntities1.STAFF.Where(h => h.staPhone == sdt).Select(n => new DTO_staff { staID = n.staID, staName = n.staName, staBirthday = n.staBirthday.Value, staAddress = n.staAddress, staPhone = n.staPhone, staSex = n.staSex.Value, staDescription = n.staDescription, staStatus = n.staStatus.Value, staSalary = n.staSalary.Value, staPosition = n.staPosition, LoginID = n.LoginID.Value }).ToList();
        }
        public List<DTO_staff> TimNhanVienTheoVitri(string viTri)
        {
            List<DTO_staff> _lstDTO_staff = new List<DTO_staff>();
            return _sellPhone_mainEntities1.STAFF.Where(h => h.staPosition == viTri).Select(n => new DTO_staff { staID = n.staID, staName = n.staName, staBirthday = n.staBirthday.Value, staAddress = n.staAddress, staPhone = n.staPhone, staSex = n.staSex.Value, staDescription = n.staDescription, staStatus = n.staStatus.Value, staSalary = n.staSalary.Value, staPosition = n.staPosition, LoginID = n.LoginID.Value }).ToList();
        }
    }
}
