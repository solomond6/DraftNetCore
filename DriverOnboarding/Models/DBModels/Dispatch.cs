using System;
using System.Collections.Generic;

namespace DriverOnboarding.Models.DBModels
{
    public partial class Dispatch
    {
        public ulong Id { get; set; }
        public string DispatchId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Phone { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
        public string Lgv { get; set; }
        public string Lcda { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
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
