using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriverOnboarding.Models
{
    public class DriverParameters
    {
        public int id { get; set; }
        public string driverscheme { get; set; }
        public sbyte guarantorOptionalForVerfication { get; set; }
        public sbyte guarantorOptionalForApprovalSubmission { get; set; }
    }
}
