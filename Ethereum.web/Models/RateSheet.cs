using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ethereum.Web.Models
{
    public class RateSheet
    {
        public string Base { get; set; }
        public DateTime Date { get; set; }
        public Dictionary<string, double> Rates { get; set; }
    }
}