using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveDetails
{
    class RequestLeave
    {
        [JsonProperty(PropertyName = "employeeId")]
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
