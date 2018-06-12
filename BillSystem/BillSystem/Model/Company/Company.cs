using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillSystem.Model
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; } 
        public string MailAddress { get; set; }
        public int PhoneNo { get; set; }
        public int MobileNo { get; set; }
        public string Address { get; set; }

    }
}
