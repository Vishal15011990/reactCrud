using System;
using System.Collections.Generic;

namespace reactCrud.Models
{
    public partial class CountryInfo
    {
        public CountryInfo()
        {
            EmpInfo = new HashSet<EmpInfo>();
            EmployeeMaster = new HashSet<EmployeeMaster>();
            StateInfo = new HashSet<StateInfo>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<EmpInfo> EmpInfo { get; set; }
        public virtual ICollection<EmployeeMaster> EmployeeMaster { get; set; }
        public virtual ICollection<StateInfo> StateInfo { get; set; }
    }
}
