using System;
using System.Collections.Generic;

namespace DriverOnboarding.Models.DBModels
{
    public partial class AppNumbersequences
    {
        public ulong Id { get; set; }
        public string SequenceId { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        public long CurrentNum { get; set; }
        public sbyte HoldDuringTransaction { get; set; }
        public int FetchAheadNumber { get; set; }
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
