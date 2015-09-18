using System.Web.Mvc;

namespace Harbour.RedisSessionStateStore.SampleWeb.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string name, int age)
        {
            Session["name"] = name;
            Session["age"] = age;
            return RedirectToAction("index");
        }

        [HttpPost]
        public ActionResult AbandonSession()
        {
            Session.Abandon();
            return RedirectToAction("index");
        }
    }
}
