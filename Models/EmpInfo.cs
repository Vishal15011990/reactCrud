using System;
using System.Collections.Generic;

namespace reactCrud.Models
{
    public partial class EmpInfo
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public int? Country { get; set; }
        public int? State { get; set; }
        public int? City { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }

        public virtual CityInfo CityNavigation { get; set; }
        public virtual CountryInfo CountryNavigation { get; set; }
        public virtual StateInfo StateNavigation { get; set; }
    }
}
