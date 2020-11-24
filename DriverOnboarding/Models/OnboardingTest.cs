using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriverOnboarding.Models
{
    public class OnboardingTest
    {
        public string VenueId { get; set; }
        public Decimal Score { get; set; }
        public Decimal PercentageScore { get; set; }
        public DateTime ActualStartDateTime { get; set; }
        public string Subject { get; set; }
        public DateTime StartDateTime { get; set; }

        
    }
}
