using Ethereum.Web.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace Ethereum.Web.Models
{
    public class FixerService : ApiController
    {
        [HttpGet]
        public RateSheet GetRates(string key)
        {
            WebClient client = new WebClient();
            var url = "http://api.fixer.io/latest?base=" + key;
            // Add an Accept header for JSON format.
            client.Headers.Set("Content-Type", "application/json");
            // List data response.
            var response = client.DownloadString(url);
            var fixerStamp = JsonConvert.DeserializeObject<RateSheet>(response);
            return fixerStamp;
        }
    }
}
