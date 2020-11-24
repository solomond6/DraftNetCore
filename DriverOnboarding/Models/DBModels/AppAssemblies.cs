using System;
using System.Collections.Generic;

namespace DriverOnboarding.Models.DBModels
{
    public partial class AppAssemblies
    {
        public ulong Id { get; set; }
        public string AssemblyName { get; set; }
        public string ViewFileLocation { get; set; }
        public string ReportFileLocation { get; set; }
        public string MachineName { get; set; }
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
