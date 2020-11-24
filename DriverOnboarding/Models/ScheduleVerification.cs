using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DriverOnboarding.Utility;

namespace DriverOnboarding.Models
{
    public class ScheduleVerification
    {
        public string Dispatchers { get; set; }

        public ScheduleFor ScheduleFor { get; set; }

        public string Drivers { get; set; }
        public string Guarantors { get; set; }
        public string LocalGovernment { get; set; }
        public string LCDA { get; set; }
        public int MaxSchedule { get; set; }
        public DateTime DispatchDate { get; set; }
        public DispatchScheduleMode ScheduleMode { get; set; }

        Dictionary<string, DispatchScheduleData> dispatchScheduleData = new Dictionary<string, DispatchScheduleData>();

    }

    public class DispatchScheduleData
    {
        public string DispatchID { get; set; }
        public int ScheduleCount { get; set; }
        public bool Sorted { get; set; }
        
        //public List<DispatchOperationalArea> OperationalAreas { get; set; }
        public List<Tuple<int, string>> OperationalAreas { get; set; }
    }
}
