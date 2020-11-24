using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriverOnboarding.Models
{
    public class Vehicles
    {
        public string id { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public string year { get; set; }
        public string color { get; set; }
        public string status { get; set; }
        public string vin { get; set; }
        public string mileage { get; set; }
        public string registration_number { get; set; }
        public string comment { get; set; }
        public string driver_id { get; set; }
        public string moove_id { get; set; }
        public string assignment_status { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime created_at { get; set; }

    }
}
