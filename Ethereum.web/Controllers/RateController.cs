using Ethereum.Web.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Ethereum.web.Controllers
{
    public class RateController : Controller
    {
        // GET: Rate
        public ActionResult Index()
        {
            Stamp stamp = new Stamp();
            ViewBag.Stamp = stamp;
            ViewBag.BaseUrl = ConfigurationManager.AppSettings["BaseUrl"];
            return View();
        }
     [HttpGet]
          public static Stamp RateRequest(Stamp stamp)
        {
            FixerService service = new FixerService();
            var response = service.GetRates(stamp.Base);
            stamp.Rates = response.Rates;
            return stamp;
        }
    }
}