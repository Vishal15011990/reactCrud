using System;
using System.Collections.Generic;

namespace reactCrud.Models
{
    public partial class EmployeeMaster
    {
        public EmployeeMaster()
        {
            Qualification = new HashSet<Qualification>();
        }

        public int EmpId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int? Country { get; set; }
        public int? State { get; set; }
        public int? City { get; set; }
        public string EmailId { get; set; }
        public int? RoleId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModiefiedOn { get; set; }
        public Guid? CreatedbY { get; set; }
        public DateTime? Createdon { get; set; }
        public string Password { get; set; }

        public virtual CityInfo CityNavigation { get; set; }
        public virtual CountryInfo CountryNavigation { get; set; }
        public virtual RoleMaster Role { get; set; }
        public virtual StateInfo StateNavigation { get; set; }
        public virtual ICollection<Qualification> Qualification { get; set; }
    }
}
