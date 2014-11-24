namespace KiedyJestWeb.Controllers
{
    using System.Web.Mvc;

    using NLog;

    /// <summary>
    /// Represents the main page controller.
    /// </summary>
    public class HomeController : Controller
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public ActionResult Index()
        {
            return View();
        }
    }
}