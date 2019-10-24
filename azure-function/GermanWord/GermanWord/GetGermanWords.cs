using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace GermanWord
{
    public static class GetGermanWords
    {
        [FunctionName("getgermanwords")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            GermanWord[] gw = new GermanWord[]
            {
                new GermanWord(1, "laufen", "verb"),
                new GermanWord(2, "Leiter", "noun"),
                new GermanWord(3, "ledig", "adjective")
            };

            return (ActionResult)new OkObjectResult(gw);
        }

        public class GermanWord
        {
            public GermanWord(int id, string word, string partOfSpeech)
            {
                this.Id = id;
                this.Word = word;
                this.PartOfSpeech = partOfSpeech;
            }
            public int Id { get; set; }
            public string Word { get; set; }
            public string PartOfSpeech { get; set; }
        }
    }
}
