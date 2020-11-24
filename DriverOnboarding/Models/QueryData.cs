using DriverOnboarding.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriverOnboarding.Models
{
    public class QueryData
    {
        public string DispatchID { get; set; }
        public DateTime DispatchDate { get; set; }
        public int ScheduleCount { get; set; }
        public List<Dispatchoperationalarea> OpA { get; set; }

        //public int ScheduleCount
        //{
        //    get
        //    {
        //        return (from ds in new QueryableEntity<DispatchSchedule>() where ds.DispatchID == DispatchID && ds.Date == DispatchDate select ds).ToList().Count;
        //    }
        //}
        //public List<Dispatchoperationalarea> OpA
        //{
        //    get
        //    {
        //        //return (from op in new QueryableEntity<DispatchOperationalArea>() where op.DispatchID == DispatchID select op).ToList();
        //    }
        //}
    }
}
