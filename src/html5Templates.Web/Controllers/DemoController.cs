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
            return RedirectToAction("KitchenSink");
        }

        public ActionResult KitchenSink()
        {
            var kitchenSink = new KitchenSink();

            return View(kitchenSink);
        }
    }
}
