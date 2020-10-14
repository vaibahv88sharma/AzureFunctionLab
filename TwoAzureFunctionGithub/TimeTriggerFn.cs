using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace TwoAzureFunctionGithub
{
    public static class TimeTriggerFn
    {
        [FunctionName("TimerTriggerCSharp")]
        public static void Run([TimerTrigger("0 */5 * * * *")] TimerInfo myTimer, ILogger log)
        {
            if (myTimer.IsPastDue)
            {
                log.LogInformation("Timer is running late!");
            }
            log.LogInformation("myTimer.Schedule ---- ",myTimer.Schedule.ToString());

            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
