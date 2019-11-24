using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryBook.Model
{
    public class RoleModel
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public string RoleActivity { get; set; }
        public string Designation { get; set; }
        public string DateCreated { get; set; }
        public string CreatedBy { get; set; }
    }
}