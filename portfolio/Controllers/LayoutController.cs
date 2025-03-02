using Microsoft.AspNetCore.Mvc;

namespace portfolio.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
