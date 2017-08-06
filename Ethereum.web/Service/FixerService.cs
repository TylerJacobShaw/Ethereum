using Ethereum.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ethereum.web.Service
{
    public class FixerService : ApiController
    {
        [HttpGet]
        public string GetRates(string key)
        {
            var request = WebRequest.Create("http://api.fixer.io/latest?base=" + key);
            request.Method = "GET";
            var response = request.GetResponse();
            return "";
        }
    }
}
