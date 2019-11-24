using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryBook.Model
{
    public class LoanModel
    {
        public int Id { get; set; }
        public string StaffId { get; set; }
        public string Department { get; set; }
        public string StaffGrade { get; set; }
        public string LoanAmount { get; set; }
        public string DateApplied { get; set; }
        public string DisbursedDate { get; set; }
        public string Status { get; set; }        
    }
}
