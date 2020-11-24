using System;
using System.Collections.Generic;

namespace DriverOnboarding.Models.DBModels
{
    public partial class Driverschemes
    {
        public ulong Id { get; set; }
        public string SchemeId { get; set; }
        public string Drn { get; set; }
        public string Name { get; set; }
        public int Principal { get; set; }
        public string LoanProductId { get; set; }
        public decimal MonthlyPayment { get; set; }
        public int Tenure { get; set; }
        public string Model { get; set; }
        public int Level { get; set; }
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
