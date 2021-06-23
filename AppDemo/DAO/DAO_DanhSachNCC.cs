using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Connecter_Tier;

namespace DAO
{
    public  class DAO_DanhSachNCC
    {
        private CSDL_sellPhone_mainEntities _sellPhone_mainEntities1 = new CSDL_sellPhone_mainEntities();
       
        public List<DTO_provided> LayDsanhSachNCC()
        {
            return _sellPhone_mainEntities1.PROVIDED.Where(h => h.provStatus == 1).Select(n => new DTO_provided { provID = n.provID, provFullName = n.provFullName, provName = n.provName, provAddress = n.provAddress, provPostOfficeCode = n.provPostOfficeCode, provCountry = n.provCountry, provPhone = n.provPhone, provDescription = n.provDescription ,provStatus = n.provStatus.Value}).ToList();
        }
        public List<DTO_provided> TimNCCTheoTen(String ten)
        {
            return _sellPhone_mainEntities1.PROVIDED.Where(h => h.provName == ten).Select(n => new DTO_provided { provID = n.provID, provFullName = n.provFullName, provName = n.provName, provAddress = n.provAddress, provPostOfficeCode = n.provPostOfficeCode, provCountry = n.provCountry, provPhone = n.provPhone, provDescription = n.provDescription }).ToList();
        }
        public List<DTO_provided> TimNCCTheoID(int id)
        {
            return _sellPhone_mainEntities1.PROVIDED.Where(h => h.provID == id).Select(n => new DTO_provided { provID = n.provID, provFullName = n.provFullName, provName = n.provName, provAddress = n.provAddress, provPostOfficeCode = n.provPostOfficeCode, provCountry = n.provCountry, provPhone = n.provPhone, provDescription = n.provDescription }).ToList();
        }
        public List<DTO_provided> TimNCCTheoDiaCHi(String diaChi)
        {
            return _sellPhone_mainEntities1.PROVIDED.Where(h => h.provAddress == diaChi).Select(n => new DTO_provided { provID = n.provID, provFullName = n.provFullName, provName = n.provName, provAddress = n.provAddress, provPostOfficeCode = n.provPostOfficeCode, provCountry = n.provCountry, provPhone = n.provPhone, provDescription = n.provDescription }).ToList();
        }
        public List<DTO_provided> TimNCCTheoSoDienThoai(String sdt)
        {
            return _sellPhone_mainEntities1.PROVIDED.Where(h => h.provPhone == sdt).Select(n => new DTO_provided { provID = n.provID, provFullName = n.provFullName, provName = n.provName, provAddress = n.provAddress, provPostOfficeCode = n.provPostOfficeCode, provCountry = n.provCountry, provPhone = n.provPhone, provDescription = n.provDescription }).ToList();
        }
        public List<DTO_provided> TimNCCTheoThanhPho(string thanhPho)
        {
            return _sellPhone_mainEntities1.PROVIDED.Where(h => h.provCountry == thanhPho).Select(n => new DTO_provided { provID = n.provID, provFullName = n.provFullName, provName = n.provName, provAddress = n.provAddress, provPostOfficeCode = n.provPostOfficeCode, provCountry = n.provCountry, provPhone = n.provPhone, provDescription = n.provDescription }).ToList();
        }
    }
}
