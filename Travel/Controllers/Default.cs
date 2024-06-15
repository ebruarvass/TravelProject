using Microsoft.AspNetCore.Mvc;

namespace Travel.Controllers
{
    public class Default : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
