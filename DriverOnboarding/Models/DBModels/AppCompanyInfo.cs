using System;
using System.Collections.Generic;

namespace DriverOnboarding.Models.DBModels
{
    public partial class AppCompanyInfo
    {
        public ulong Id { get; set; }
        public string CompanyId { get; set; }
        public string Smtphost { get; set; }
        public int Smtpport { get; set; }
        public string SmtpoutgoingEmail { get; set; }
        public string SmtpoutgoingEmailName { get; set; }
        public string Smtpusername { get; set; }
        public string Smtppassword { get; set; }
        public sbyte UseSslforSmtp { get; set; }
        public string LogoPath { get; set; }
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
