using System;
using System.Collections.Generic;

namespace DriverOnboarding.Models.DBModels
{
    public partial class Guarantordetails
    {
        public ulong Id { get; set; }
        public string Drn { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string LocalGovernmentArea { get; set; }
        public string Lcda { get; set; }
        public sbyte Scheduled { get; set; }
        public sbyte SubmittedForApproval { get; set; }
        public string PlaceofWork { get; set; }
        public string OfficeAddress { get; set; }
        public string PositionHeld { get; set; }
        public string Remark { get; set; }
        public string RemarkReason { get; set; }
        public string Occupation { get; set; }
        public string BankName { get; set; }
        public string Bvn { get; set; }
        public string AccountNumber { get; set; }
        public string Branch { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string Company { get; set; }
        public long RecordVersion { get; set; }
        public long Deleted { get; set; }
        public string GuarantorId { get; set; }
    }
}
