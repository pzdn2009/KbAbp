using System.Web.Mvc;

namespace KbAbp.Web.Controllers
{
    public class HomeController : KbAbpControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}