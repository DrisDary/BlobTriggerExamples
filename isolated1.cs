using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace FunctionApp1
{
    public static class isolated1
    {
        [Function(nameof(isolated1))]
        [BlobOutput("testcontainer/isolated1.xlsx")]
        public static string Run(
            [BlobTrigger("%blobpath%")] string myTriggerItem,
            [BlobInput("testcontainer/testfile.xlsx")] string myBlob,
            FunctionContext context)
        {
            var logger = context.GetLogger("BlobFunction");
            logger.LogInformation("isolated1");
            logger.LogInformation("Triggered Item = {myTriggerItem}", myTriggerItem);
            logger.LogInformation("Input Item = {myBlob}", myBlob);

            // Blob Output
            return "blob-output content";
        }
    }
}
