﻿using System;
using System.Collections.Generic;

namespace DriverOnboarding.Models.DBModels
{
    public partial class Guarantordocuments
    {
        public ulong Id { get; set; }
        public long GuarantorId { get; set; }
        public string Drn { get; set; }
        public string DocumentType { get; set; }
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
