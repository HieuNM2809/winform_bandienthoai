using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class DAO_NhapHang
    {
        CSDL_sellPhone_mainEntities _SellPhone_MainEntities = new CSDL_sellPhone_mainEntities();
        public bool ThemSanPham(DTO_product _Product)
        {
            try
            {
                int tam = _SellPhone_MainEntities.ThemSanPham( _Product.prodName, _Product.prodPrice, _Product.prodSL, _Product.prodCamera, _Product.prodMenory, _Product.prodReleaseYear, _Product.prodRAM, _Product.prodDescription, _Product.provID, _Product.catID);
               _SellPhone_MainEntities.SaveChanges();

                return tam>0;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
        public bool ThemOrder(DTO_order _Order)
        {
          //  try
            //{
                int tam = _SellPhone_MainEntities.ThemOrder(_Order.ordDate, _Order.ordDescription, _Order.staID);
                _SellPhone_MainEntities.SaveChanges();
                return tam > 0;
            //}
            //catch (Exception)
            //{
            //    return false;
            //}
        }
        public bool ThemInfoOrder(DTO_informationOrder _InfoOrder)
        {
            int tam = _SellPhone_MainEntities.ThemInfoOrder(_InfoOrder.ordID, _InfoOrder.prodID, _InfoOrder.infoOrderSl, _InfoOrder.infoOrderPrice);
            _SellPhone_MainEntities.SaveChanges();
            return true;
        }

        public bool SuaSanPham(DTO_product _DTO_product)
        {
            try
            {
                PRODUCT product = _SellPhone_MainEntities.PRODUCT.SingleOrDefault(u => u.prodStatus == 1 && u.prodID == _DTO_product.prodID);


                product.prodID = _DTO_product.prodID;
                product.prodName = _DTO_product.prodName;
                product.prodPrice = _DTO_product.prodPrice;
                product.prodSL = _DTO_product.prodSL;
                product.prodCamera = _DTO_product.prodCamera;
                product.prodMenory = _DTO_product.prodMenory;
                product.prodReleaseYear = _DTO_product.prodReleaseYear;
                product.prodRAM = _DTO_product.prodRAM;
                product.prodDescription = _DTO_product.prodDescription;
                product.provID = _DTO_product.provID;
                product.catID = _DTO_product.catID;

                _SellPhone_MainEntities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool XoaSanPham(int id)
        {
            try { 
                PRODUCT product = _SellPhone_MainEntities.PRODUCT.SingleOrDefault(u=> u.prodID == id);
                product.prodStatus = 0;
                _SellPhone_MainEntities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<DTO_staff> TimNhanVienTheoID(int id)
        {
            List<DTO_staff> _lstDTO_staff = new List<DTO_staff>();
            return _SellPhone_MainEntities.STAFF.Where(h => h.LoginID == id).Select(n => new DTO_staff { staID = n.staID, staName = n.staName, staBirthday = n.staBirthday.Value, staAddress = n.staAddress, staPhone = n.staPhone, staSex = n.staSex.Value, staDescription = n.staDescription, staStatus = n.staStatus.Value, staSalary = n.staSalary.Value, staPosition = n.staPosition, LoginID = n.LoginID.Value }).ToList();
        }
    }
}
