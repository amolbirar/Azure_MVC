using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasicApp.Controllers
{
    public class PotsController : Controller
    {
        // GET: Pots
        public ActionResult Index()
        {
            return View();
        }
    }
}