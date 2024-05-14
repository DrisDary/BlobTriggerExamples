
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace FunctionApp1
{
    public static class isolated2
    {
        [FunctionName("isolated2")]
        [BlobOutput("testcontainer/isolated2.xlsx")]
        public static string Run(
            [BlobTrigger("%blobpath%")] string myTriggerItem,
            [BlobInput("testcontainer/testfile.xlsx")] string myBlob,
            FunctionContext context)
        {
            var logger = context.GetLogger("BlobFunction");
            logger.LogInformation("isolated2");
            logger.LogInformation("Triggered Item = {myTriggerItem}", myTriggerItem);
            logger.LogInformation("Input Item = {myBlob}", myBlob);

            // Blob Output
            return "blob-output content";
        }
    }
}
