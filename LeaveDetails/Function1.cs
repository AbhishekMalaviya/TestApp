using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace LeaveDetails
{
    public static class Function1
    {
        [FunctionName("MyLeaveDetails")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("Logging the MyLeaveDetails request.");

            List<RequestLeave> lst = null;
            string EmployeeId = string.Empty;

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            EmployeeId = data?.employeeId;


            if (EmployeeId != null)
            {
                lst = new List<RequestLeave>();
                for (int i = 1; i < 4; i++)
                {
                    lst.Add(new RequestLeave() { EmployeeId = "40", EmployeeName = $"Employee {i}", FromDate = DateTime.Now.AddDays(-i - 1), ToDate = DateTime.Now.AddDays(-i) });
                }

                return (ActionResult)new OkObjectResult(lst);
            }

            return new BadRequestObjectResult("Pass an employee Id in the request body");
        }
    }
}

