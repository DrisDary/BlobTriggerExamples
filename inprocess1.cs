using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace FunctionApp1
{
    public class inprocess1
    {
        [Function(nameof(inprocess1))]
        public void Run([BlobTrigger("%blobpath%", Connection = "AzureWebJobsStorage")]string myBlob, string name, ILogger log)
        {
            log.LogInformation($"inprocess1 trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }
    }
}
