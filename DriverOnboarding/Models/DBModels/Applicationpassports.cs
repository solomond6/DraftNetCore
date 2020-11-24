using System;
using System.Collections.Generic;

namespace DriverOnboarding.Models.DBModels
{
    public partial class Applicationpassports
    {
        public ulong Id { get; set; }
        public string RefNo { get; set; }
        public byte[] PassportData { get; set; }
        public string ImageType { get; set; }
        public string Branch { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string Company { get; set; }
        public long RecordVersion { get; set; }
        public long Deleted { get; set; }
    }
}
