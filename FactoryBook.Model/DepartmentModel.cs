using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryBook.Model
{
    public class DepartmentModel
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string SubDepartment { get; set; }
        public string Hod { get; set; }
        public string DateCreated { get; set; }
        public string CreatedBy { get; set; }
    }
}