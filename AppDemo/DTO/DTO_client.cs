using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_client
    {
        public int cliID { get; set; }
        public String cliName { get; set; }
        public String cliAddress { get; set; }
        public String cliCountry { get; set; }
        public String cliPostOfficeCode { get; set; }
        public String cliPhone { get; set; }
        public int cliStatus { get; set; }
    }
}
