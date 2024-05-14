using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace FunctionApp1
{
    public class inprocess2
    {
        [FunctionName("inprocess2")]
        public void Run([BlobTrigger("%blobpath%", Connection = "AzureWebJobsStorage")] string myBlob, string name, ILogger log)
        {
            log.LogInformation($"inprocess2 trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }
    }
}
