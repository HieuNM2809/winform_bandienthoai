using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class BUS_ThemNhaSanXuat
    {
        private DAO_ThemNhaSanXuat _DAO_ThemNhaSanXuat = new DAO_ThemNhaSanXuat();
        public bool ThemNCC(DTO_provided _DTO_provided)
        {
            return _DAO_ThemNhaSanXuat.ThemNCC(_DTO_provided);
        }
        public bool XoaNCC(int id)
        {
            return _DAO_ThemNhaSanXuat.XoaNCC(id);
        }
        public bool SuaNCC(DTO_provided _DTO_provdid)
        {
            return _DAO_ThemNhaSanXuat.SuaNCC(_DTO_provdid);
        }
    }
}
