using System;
using System.Collections.Generic;

namespace reactCrud.Models
{
    public partial class MasterAdmin
    {
        public int Id { get; set; }
        public string AdminName { get; set; }
        public string AdminPassword { get; set; }
    }
}
