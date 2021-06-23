using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Connecter_Tier;
using DTO;

namespace DAO
{
    public class DAO_ThemNhaSanXuat
    {
        private CSDL_sellPhone_mainEntities _sellPhone_mainEntities = new CSDL_sellPhone_mainEntities();
        public bool ThemNCC(DTO_provided _DTO_provided)
        {
            try
            {
                int tam1 = _sellPhone_mainEntities.ThemNhaCungCap(_DTO_provided.provFullName, _DTO_provided.provName, _DTO_provided.provAddress, _DTO_provided.provPostOfficeCode, _DTO_provided.provCountry, _DTO_provided.provPhone, _DTO_provided.provDescription, _DTO_provided.provStatus);
                _sellPhone_mainEntities.SaveChanges();
               return tam1 > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool XoaNCC(int id)
        {
            try
            {
                PROVIDED provided = _sellPhone_mainEntities.PROVIDED.SingleOrDefault(u => u.provID == id && u.provStatus == 1);
                provided.provStatus = 0;

                _sellPhone_mainEntities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool SuaNCC(DTO_provided _DTO_provdid)
        {
            try
            {
                PROVIDED provided = _sellPhone_mainEntities.PROVIDED.SingleOrDefault(u => u.provID == _DTO_provdid.provID && u.provStatus == 1);

                provided.provFullName = _DTO_provdid.provFullName;
                provided.provName = _DTO_provdid.provName;
                provided.provAddress = _DTO_provdid.provAddress;
                provided.provPostOfficeCode = _DTO_provdid.provPostOfficeCode;
                provided.provCountry = _DTO_provdid.provCountry;
                provided.provPhone = _DTO_provdid.provPhone;
                provided.provDescription = _DTO_provdid.provDescription;
                provided.provStatus = _DTO_provdid.provStatus;

                _sellPhone_mainEntities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

    }
}
