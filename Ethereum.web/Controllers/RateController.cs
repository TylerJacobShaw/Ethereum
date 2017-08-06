using Ethereum.web.Service;
using Ethereum.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            return View();
        }
        public Stamp RateRequest(Stamp stamp)
        {
            FixerService service = new FixerService();
            service.GetRates(stamp.Base);
            return stamp;
        }
    }
}