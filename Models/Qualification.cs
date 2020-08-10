using System;
using System.Collections.Generic;

namespace reactCrud.Models
{
    public partial class Qualification
    {
        public int Id { get; set; }
        public int QualRefId { get; set; }
        public int EmRefId { get; set; }

        public virtual EmployeeMaster EmRef { get; set; }
        public virtual QualificationMaster QualRef { get; set; }
    }
}
