using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeService.Models.Request
{
    public class AddBillRequest
    {
        public string HosId { get; set; }
        public string PatientId { get; set; }
    }
}
