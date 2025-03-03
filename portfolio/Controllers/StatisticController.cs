using Microsoft.AspNetCore.Mvc;
using portfolio.DAL.Context;

namespace portfolio.Controllers
{
    public class StatisticController : Controller
    {   PortfolioContext context = new PortfolioContext();
        public IActionResult Index()
        {   ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Count();
            ViewBag.v3 = context.Messages.Where(x => x.IsRead== true).Count();
            ViewBag.v4 = context.Messages.Where(x => x.IsRead == false).Count();
            return View();
        }
    }
}
