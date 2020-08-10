using System;
using System.Collections.Generic;

namespace reactCrud.Models
{
    public partial class CityInfo
    {
        public CityInfo()
        {
            EmpInfo = new HashSet<EmpInfo>();
            EmployeeMaster = new HashSet<EmployeeMaster>();
        }

        public int CityId { get; set; }
        public int? StateRefId { get; set; }
        public string CityName { get; set; }

        public virtual StateInfo StateRef { get; set; }
        public virtual ICollection<EmpInfo> EmpInfo { get; set; }
        public virtual ICollection<EmployeeMaster> EmployeeMaster { get; set; }
    }
}
