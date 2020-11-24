using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriverOnboarding.Models
{
    public class AddressVerificationResult
    {
        public long DispatchScheduleId { get; set; }
        public string Gps { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
        public string StatusReason { get; set; }
        public string VerificationItem { get; set; }
        public ulong Id { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageType { get; set; }

    }
}
