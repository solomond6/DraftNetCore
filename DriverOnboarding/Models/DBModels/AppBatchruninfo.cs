using System;
using System.Collections.Generic;

namespace DriverOnboarding.Models.DBModels
{
    public partial class AppBatchruninfo
    {
        public ulong Id { get; set; }
        public long BatchInfoId { get; set; }
        public string RunnableClassName { get; set; }
        public string RunnableCaption { get; set; }
        public DateTime ProposedStartDateTime { get; set; }
        public DateTime ActualStartDateTime { get; set; }
        public decimal Progress { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Status { get; set; }
        public int ExitCode { get; set; }
        public byte[] InfologData { get; set; }
        public int Pid { get; set; }
        public long PrintArchiveId { get; set; }
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
