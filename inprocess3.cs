using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace FunctionApp1
{
    public class inprocess3
    {
        private readonly ILogger _logger;

        public inprocess3(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<inprocess3>();
        }

        [Function(nameof(inprocess3))]
        public async Task Run([BlobTrigger("%blobpath%" , Connection = "AzureWebJobsStorage")] string myBlob, string name)
        {
            _logger.LogInformation($"inprocess3 trigger function Processed blob\n Name: {name} \n Data: {myBlob}");
        }
    }
}
