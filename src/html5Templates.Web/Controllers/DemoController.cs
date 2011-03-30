using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using html5Templates.Web.Models;

namespace html5Templates.Web.Controllers
{
    public class DemoController : Controller
    {
        //
        // GET: /Demo/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult KitchenSink()
        {
            var kitchenSink = new KitchenSink();

            return View(kitchenSink);
        }
    }
}
