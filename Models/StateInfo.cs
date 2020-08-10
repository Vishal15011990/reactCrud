using System;
using System.Collections.Generic;

namespace reactCrud.Models
{
    public partial class StateInfo
    {
        public StateInfo()
        {
            CityInfo = new HashSet<CityInfo>();
            EmpInfo = new HashSet<EmpInfo>();
            EmployeeMaster = new HashSet<EmployeeMaster>();
        }

        public int StateId { get; set; }
        public string StateName { get; set; }
        public int? CountryRefId { get; set; }

        public virtual CountryInfo CountryRef { get; set; }
        public virtual ICollection<CityInfo> CityInfo { get; set; }
        public virtual ICollection<EmpInfo> EmpInfo { get; set; }
        public virtual ICollection<EmployeeMaster> EmployeeMaster { get; set; }
    }
}
