namespace KiedyJestWeb.Controllers
{
    using System.Web.Mvc;

    /// <summary>
    /// Represents the main page controller.
    /// </summary>
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}