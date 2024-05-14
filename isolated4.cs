using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace FunctionApp1
{
    public static class isolated4
    {
        [FunctionName("isolated4")]
        [BlobOutput("testcontainer/isolated4.xlsx")]
        public static async Task Run(
            [BlobTrigger("%blobpath%")] string myTriggerItem,
            [BlobInput("testcontainer/testfile.xlsx")] string myBlob,
            FunctionContext context)
        {
            var logger = context.GetLogger("BlobFunction");
            logger.LogInformation("isolated4");
            logger.LogInformation("Triggered Item = {myTriggerItem}", myTriggerItem);
            logger.LogInformation("Input Item = {myBlob}", myBlob);

        }
    }
}
    