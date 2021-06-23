using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class DTO_order
    {
      public int ordID { get; set; }
      public DateTime ordDate { get; set; }
      public String ordDescription { get; set; }
      public bool ordBill { get; set; }
      public String ordStatus { get; set; }
      public int cliID { get; set; }
      public int staID { get; set; }
      public int shiID { get; set; }
    }
}
