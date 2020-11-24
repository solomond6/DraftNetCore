using System;
using System.Collections.Generic;

namespace DriverOnboarding.Models.DBModels
{
    public partial class AppFailedlogins
    {
        public ulong Id { get; set; }
        public string Username { get; set; }
        public string Server { get; set; }
        public string ServerName { get; set; }
        public DateTime LogOnDateTime { get; set; }
        public string ClientIp { get; set; }
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
