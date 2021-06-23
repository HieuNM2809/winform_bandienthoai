using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class DTO_informationOrder
    {
        public int infoOrderID { get; set; }
        public int ordID { get; set; }
        public int prodID { get; set; }
        public int infoOrderSl { get; set; }
        public int infoOrderPrice { get; set; }
        public String  infoStatus { get; set; } 
    }
}
