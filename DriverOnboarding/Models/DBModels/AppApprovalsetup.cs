using System;
using System.Collections.Generic;

namespace DriverOnboarding.Models.DBModels
{
    public partial class AppApprovalsetup
    {
        public ulong Id { get; set; }
        public string EntityName { get; set; }
        public int ApprovalSno { get; set; }
        public string ApprovalName { get; set; }
        public string EligigleRecordsQuery { get; set; }
        public string ApproverUsersQuery { get; set; }
        public sbyte AutoApprove { get; set; }
        public string AutoApprovalStatus { get; set; }
        public string AutoApprovalReason { get; set; }
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
