using System;
using System.Collections.Generic;

namespace DriverOnboarding.Models.DBModels
{
    public partial class Examinationschedulequestionoptions
    {
        public ulong Id { get; set; }
        public long ExaminationScheduleId { get; set; }
        public int OptionNo { get; set; }
        public long ExaminationQuestionId { get; set; }
        public long ExaminationQuestionOptionId { get; set; }
        public sbyte Selected { get; set; }
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
