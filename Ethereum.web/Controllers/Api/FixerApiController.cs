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
    public class FixerApiController : ApiController
    {
        [HttpPost]
        public Stamp PostRates(Stamp stamp)
        {
            WebClient client = new WebClient();
            var url = "http://api.fixer.io/latest?base=" + stamp.Base;
            // Add an Accept header for JSON format.
            client.Headers.Set("Content-Type", "application/json");
            // List data response.
            var response = client.DownloadString(url);
            var stampObj = JsonConvert.DeserializeObject<RateSheet>(response);
            foreach (var item in stampObj.Rates)
            {
                stamp.Rates.Add(
                 new Conversion()
                 {
                     Key = item.Key,
                     Value = item.Value
                 });
                 }
            return stamp;
        }
    }
}
