using System;
using System.Collections.Generic;

namespace reactCrud.Models
{
    public partial class RoleMaster
    {
        public RoleMaster()
        {
            EmployeeMaster = new HashSet<EmployeeMaster>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public Guid Createdby { get; set; }
        public DateTime Createdon { get; set; }
        public bool IsDelete { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<EmployeeMaster> EmployeeMaster { get; set; }
    }
}
