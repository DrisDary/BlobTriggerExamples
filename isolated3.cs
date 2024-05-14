using System;
using System.IO;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace FunctionApp1
{
    public static class isolated3
    {
        [FunctionName("isolated3")]
        [BlobOutput("testcontainer/isolated3.xlsx")]
        public static void Run(
            [BlobTrigger("%blobpath%")] string myTriggerItem,
            [BlobInput("testcontainer/testfile.xlsx")] string myBlob,
            FunctionContext context)
        {
            var logger = context.GetLogger("BlobFunction");
            logger.LogInformation("isolated3");
            logger.LogInformation("Triggered Item = {myTriggerItem}", myTriggerItem);
            logger.LogInformation("Input Item = {myBlob}", myBlob);

        }
    }
}
