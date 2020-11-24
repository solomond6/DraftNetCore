using System;
using System.Collections.Generic;

namespace DriverOnboarding.Models.DBModels
{
    public partial class AppUserbrowserfingerprinthashes
    {
        public ulong Id { get; set; }
        public string User { get; set; }
        public string FingerprintHash { get; set; }
        public DateTime ExpiryDateTime { get; set; }
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
