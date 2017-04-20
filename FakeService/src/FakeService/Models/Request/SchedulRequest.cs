using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeService.Models.Request
{
    public class SchedulRequest
    {
        public string HosId { get; set; }
        public string TypeId { get; set; }
        public string DeptId { get; set; }
        public string DoctorId { get; set; }
        public string Date { get; set; }
        public string AMPMId { get; set; }
    }
}
