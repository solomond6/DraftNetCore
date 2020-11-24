using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriverOnboarding.Models
{
    public class DriverDocumentSetup
    {
        public int id { get; set; }
        public string docName { get; set; }
        public string docType { get; set; }
        public string docStatus { get; set; }
    }
}
