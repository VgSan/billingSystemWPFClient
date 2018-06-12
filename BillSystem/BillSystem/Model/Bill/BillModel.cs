using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillSystem.Model.Bill
{
    public class BillModel
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int BowserId { get; set; }

        public int BillNo { get; set; }
        public int EmployeeId { get; set; }

        public string BillDate { get; set; }

        public int BillTotal { get; set; }

        public int Quantity { get; set; }
    }
}
