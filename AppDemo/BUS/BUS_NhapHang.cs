using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class BUS_NhapHang
    {
        DAO_NhapHang _DAO_NhapHang = new DAO_NhapHang();
        public bool XoaSanPham(int id)
        {
           return _DAO_NhapHang.XoaSanPham(id);
        }
        public bool SuaSanPham(DTO_product _DTO_product)
        {
            return _DAO_NhapHang.SuaSanPham(_DTO_product);
        }
        public bool ThemSanPham(DTO_product _Product)
        {
            return _DAO_NhapHang.ThemSanPham(_Product);
        }
        public bool ThemOrder(DTO_order _Order)
        {
            return _DAO_NhapHang.ThemOrder(_Order);
        }
        public bool ThemInfoOrder(DTO_informationOrder _InfoOrder)
        {
            return _DAO_NhapHang.ThemInfoOrder(_InfoOrder);
        }
        public List<DTO_staff> TimNhanVienTheoID(int id)
        {
            return _DAO_NhapHang.TimNhanVienTheoID(id);
        }

    }
}
