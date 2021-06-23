using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_staff
    {
        public int staID { get; set; }
        public String staName { get; set; }
        public DateTime staBirthday { get; set; }
        public String staAddress { get; set; }
        public String staImg { get; set; }
        public String staPhone { get; set; }
        public bool staSex { get; set; }
        public String staDescription { get; set; }
        public int staStatus { get; set; }
        public decimal staSalary { get; set; }
        public String staPosition { get; set; }
        public int LoginID { get; set; }
    }
}
