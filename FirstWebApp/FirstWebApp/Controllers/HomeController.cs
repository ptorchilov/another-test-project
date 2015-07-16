using System.Web.Mvc;

using FirstWebApp.Interfaces;
using FirstWebApp.Services;

namespace FirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        private INumbers numbersService;

        public HomeController()
        {
            numbersService = new NumbersService();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Numbers = numbersService.GetNumbers(10);

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}