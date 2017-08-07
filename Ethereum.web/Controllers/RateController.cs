using Ethereum.Web.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
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
    }
}