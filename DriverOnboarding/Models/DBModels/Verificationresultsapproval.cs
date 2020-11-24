using System;
using System.Collections.Generic;

namespace DriverOnboarding.Models.DBModels
{
    public partial class Verificationresultsapproval
    {
        public ulong Id { get; set; }
        public string Drn { get; set; }
        public string GuarantorId { get; set; }
        public string VerificationItem { get; set; }
        public string Category { get; set; }
        public sbyte FirstApproval { get; set; }
        public sbyte SecondApproval { get; set; }
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
