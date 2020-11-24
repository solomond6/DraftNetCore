using System;
using System.Collections.Generic;

namespace DriverOnboarding.Models.DBModels
{
    public partial class Verificationresult
    {
        public ulong Id { get; set; }
        public string RefNo { get; set; }
        public string VerificationItem { get; set; }
        public string Gps { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
        public string StatusReason { get; set; }
        public string Branch { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string Company { get; set; }
        public long RecordVersion { get; set; }
        public long Deleted { get; set; }
        public long DispatchScheduleId { get; set; }
    }
}
