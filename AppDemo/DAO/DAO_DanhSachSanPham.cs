using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Connecter_Tier;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_DanhSachSanPham
    {
        private CSDL_sellPhone_mainEntities _sellPhone_mainEntities = new CSDL_sellPhone_mainEntities();
        private DP db = new DP();
        public List<DTO_product> TimTheoTenGanDung(String ten)
        {
            SqlConnection con =   db.connection_DB();
            String query = "select prodID,prodName, prodPrice,prodSL, prodInit," +
             " prodCamera,prodMenory,prodReleaseYear,prodRAM ,prodDescription ," +
             "provID ,catID,prodStatus  from product where prodName like N'%" +ten +"%' ";
            List<SqlParameter> lstPara = new List<SqlParameter>();
            lstPara.Add(new SqlParameter("@name", ten));
            SqlDataReader sdr = db.run_query_select(query, lstPara, con);

            List<DTO_product> lstpro = new List<DTO_product>(); 
            if (sdr.HasRows)
            {
                while(sdr.Read())
                {
                    DTO_product pro = new DTO_product(); 
                    pro.prodID = sdr.GetInt32(0);
                    pro.prodName = sdr.GetString(1);
                   // pro.prodPrice = Convert.ToDecimal(sdr.GetDouble(2));
                    pro.prodSL = sdr.GetInt32(3);
                    pro.prodInit = sdr.GetString(4);
                    pro.prodCamera = sdr.GetString(5);
                    pro.prodMenory = sdr.GetInt32(6);
                    pro.prodReleaseYear = sdr.GetInt32(7);
                    pro.prodRAM = sdr.GetInt32(8);
                   // pro.prodDescription = sdr.GetString(9);
                    pro.provID = sdr.GetInt32(10);
                    pro.catID = sdr.GetInt32(11);
                    pro.prodStatus = sdr.GetInt32(12);

                    lstpro.Add(pro);
                }
            }
            db.Close_connection_DB(con);

            return lstpro;

        }
        public List<DTO_product> LayDanhSachSanPham()
        {
            List<DTO_product> lstDS = new List<DTO_product>();
            lstDS = _sellPhone_mainEntities.PRODUCT.Where(u => u.prodStatus == 1).Select(v => new DTO_product { prodID = v.prodID, prodName = v.prodName, prodPrice = v.prodPrice.Value, prodSL = v.prodSL.Value, prodInit = v.prodInit, prodCamera = v.prodCamera, prodMenory= v.prodMenory.Value, prodReleaseYear = v.prodReleaseYear.Value, prodDescription = v.prodDescription , prodStatus = v.prodStatus.Value, provID = v.provID.Value , catID = v.catID.Value , prodRAM = v.prodRAM.Value}).ToList();
            return lstDS;
        }
        public List<DTO_provided> LayDanhSachNCC()
        {
            return _sellPhone_mainEntities.PROVIDED.Where(u=> u.provStatus ==1).Select(v=> new DTO_provided { provID = v.provID ,provName = v.provName}).ToList();        
        }




        public List<DTO_product> TimTheoTen(String ten)
        {
            return _sellPhone_mainEntities.PRODUCT.Where(u => u.prodName == ten).Select(v => new DTO_product { prodID = v.prodID, prodName = v.prodName, prodPrice = v.prodPrice.Value, prodSL = v.prodSL.Value, prodInit = v.prodInit, prodCamera = v.prodCamera, prodMenory = v.prodMenory.Value, prodReleaseYear = v.prodReleaseYear.Value, prodDescription = v.prodDescription, prodStatus = v.prodStatus.Value, provID = v.provID.Value, catID = v.catID.Value }).ToList();          
        }
        public List<DTO_product> TimTheoRam(String ram)
        {
            
             int RAM = Convert.ToInt32(ram);
             return _sellPhone_mainEntities.PRODUCT.Where(u => u.prodRAM == RAM).Select(v => new DTO_product { prodID = v.prodID, prodName = v.prodName, prodPrice = v.prodPrice.Value, prodSL = v.prodSL.Value, prodInit = v.prodInit, prodCamera = v.prodCamera, prodMenory = v.prodMenory.Value, prodReleaseYear = v.prodReleaseYear.Value, prodDescription = v.prodDescription, prodStatus = v.prodStatus.Value, provID = v.provID.Value, catID = v.catID.Value }).ToList();
            
        }
        public List<DTO_product> TimTheoID(String id)
        {
            int ID = Convert.ToInt32(id);
            return _sellPhone_mainEntities.PRODUCT.Where(u => u.prodID == ID).Select(v => new DTO_product { prodID = v.prodID, prodName = v.prodName, prodPrice = v.prodPrice.Value, prodSL = v.prodSL.Value, prodInit = v.prodInit, prodCamera = v.prodCamera, prodMenory = v.prodMenory.Value, prodReleaseYear = v.prodReleaseYear.Value, prodDescription = v.prodDescription, prodStatus = v.prodStatus.Value, provID = v.provID.Value, catID = v.catID.Value }).ToList();
          
        }
         public List<DTO_product> TimTheoGia(String giaTu ,String giaDen)
        {
            decimal GIATU = Convert.ToDecimal(giaTu);
            decimal GIADEN = Convert.ToDecimal(giaDen);
            return _sellPhone_mainEntities.PRODUCT.Where(u => u.prodPrice  >= GIATU && u.prodPrice <=GIADEN).Select(v => new DTO_product { prodID = v.prodID, prodName = v.prodName, prodPrice = v.prodPrice.Value, prodSL = v.prodSL.Value, prodInit = v.prodInit, prodCamera = v.prodCamera, prodMenory = v.prodMenory.Value, prodReleaseYear = v.prodReleaseYear.Value, prodDescription = v.prodDescription, prodStatus = v.prodStatus.Value, provID = v.provID.Value, catID = v.catID.Value }).ToList();
        }
        public List<DTO_product> TimTheoNamSX(String namSX)
        {
            int NAMSX= Convert.ToInt32(namSX);
            return _sellPhone_mainEntities.PRODUCT.Where(u => u.prodReleaseYear == NAMSX).Select(v => new DTO_product { prodID = v.prodID, prodName = v.prodName, prodPrice = v.prodPrice.Value, prodSL = v.prodSL.Value, prodInit = v.prodInit, prodCamera = v.prodCamera, prodMenory = v.prodMenory.Value, prodReleaseYear = v.prodReleaseYear.Value, prodDescription = v.prodDescription, prodStatus = v.prodStatus.Value, provID = v.provID.Value, catID = v.catID.Value }).ToList();
        }
        public List<DTO_product> TimTheoLoai(String loai)
        {
            int id_loai = 0;
            if (loai == "Điện thoại Phím")
            {
                id_loai = 1;
            }
            else if (loai == "Điện thoại Cảm ứng")
            {
                id_loai = 2;
            }
            else if (loai == "Điện thoại Gaming")
            {
                id_loai = 3;
            }
            return _sellPhone_mainEntities.PRODUCT.Where(u => u.catID == id_loai).Select(v => new DTO_product { prodID = v.prodID, prodName = v.prodName, prodPrice = v.prodPrice.Value, prodSL = v.prodSL.Value, prodInit = v.prodInit, prodCamera = v.prodCamera, prodMenory = v.prodMenory.Value, prodReleaseYear = v.prodReleaseYear.Value, prodDescription = v.prodDescription, prodStatus = v.prodStatus.Value, provID = v.provID.Value, catID = v.catID.Value }).ToList();
        }

        public List<DTO_product> TimTheoNhaSX(int nhaSX)
        {
            return _sellPhone_mainEntities.PRODUCT.Where(u => u.provID == nhaSX).Select(v => new DTO_product { prodID = v.prodID, prodName = v.prodName, prodPrice = v.prodPrice.Value, prodSL = v.prodSL.Value, prodInit = v.prodInit, prodCamera = v.prodCamera, prodMenory = v.prodMenory.Value, prodReleaseYear = v.prodReleaseYear.Value, prodDescription = v.prodDescription, prodStatus = v.prodStatus.Value, provID = v.provID.Value, catID = v.catID.Value }).ToList();
        }



    }
    
}
