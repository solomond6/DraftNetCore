using System;
using System.Collections.Generic;

namespace DriverOnboarding.Models.DBModels
{
    public partial class AppSystemparameters
    {
        public ulong Id { get; set; }
        public int MaxLoginAttempts { get; set; }
        public string HelpSiteUrl { get; set; }
        public sbyte UserMustChangePasswordOnFirstLogin { get; set; }
        public string AcceptablePasswordRegex { get; set; }
        public string AcceptablePasswordDescription { get; set; }
        public string UseTwoFactorAuthentication { get; set; }
        public int UserBrowserFingerprintExpiryMinutes { get; set; }
        public int TwoFactorTokenExpiryMinutes { get; set; }
        public string DefaultFormAccessLevel { get; set; }
        public string DefaultDataFormAccessLevel { get; set; }
        public string DefaultEntityAccessLevel { get; set; }
        public string DefaultFieldAccessLevel { get; set; }
        public string DefaultReportAccessLevel { get; set; }
        public string DefaultRunnableAccessLevel { get; set; }
        public string DefaultOperationAccessLevel { get; set; }
        public string DefaultMenuAccessLevel { get; set; }
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
