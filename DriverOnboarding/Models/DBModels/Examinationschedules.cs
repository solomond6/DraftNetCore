using System;
using System.Collections.Generic;

namespace DriverOnboarding.Models.DBModels
{
    public partial class Examinationschedules
    {
        public ulong Id { get; set; }
        public string RefNo { get; set; }
        public string VenueId { get; set; }
        public long ExaminationId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime ActualStartDateTime { get; set; }
        public string Status { get; set; }
        public int Score { get; set; }
        public decimal PercentageScore { get; set; }
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
