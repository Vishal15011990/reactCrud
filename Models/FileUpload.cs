using System;
using System.Collections.Generic;

namespace reactCrud.Models
{
    public partial class FileUpload
    {
        public Guid UploadId { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string FileSize { get; set; }
        public string FilePath { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid Userid { get; set; }
    }
}
