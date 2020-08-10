using System;
using System.Collections.Generic;

namespace reactCrud.Models
{
    public partial class QualificationMaster
    {
        public QualificationMaster()
        {
            QualificationNavigation = new HashSet<Qualification>();
        }

        public int Id { get; set; }
        public string Qualification { get; set; }

        public virtual ICollection<Qualification> QualificationNavigation { get; set; }
    }
}
