using System;
using System.Collections.Generic;

namespace DriverOnboarding.Models.DBModels
{
    public partial class AppUsers
    {
        public ulong Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Supervisor { get; set; }
        public sbyte ForceChangePassword { get; set; }
        public string Password { get; set; }
        public sbyte CanChangeCompany { get; set; }
        public sbyte Enabled { get; set; }
        public string DefaultCompany { get; set; }
        public string PreviousCompany { get; set; }
        public int LoginFailCount { get; set; }
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
