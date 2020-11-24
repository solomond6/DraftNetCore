using System;
using System.Collections.Generic;

namespace DriverOnboarding.Models.DBModels
{
    public partial class AppBatchinfo
    {
        public ulong Id { get; set; }
        public string RunnableClassName { get; set; }
        public string RunnableCaption { get; set; }
        public sbyte Alerts { get; set; }
        public byte[] SerializedObject { get; set; }
        public DateTime LastRunDateTime { get; set; }
        public DateTime ProposedStartDateTime { get; set; }
        public DateTime NextProposedRunDateTime { get; set; }
        public string RecurrencePeriod { get; set; }
        public int RecurrencePeriodGap { get; set; }
        public int MaxRecurrenceCount { get; set; }
        public int RecurrenceCount { get; set; }
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
