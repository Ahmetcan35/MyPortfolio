using Microsoft.AspNetCore.Mvc;
using portfolio.DAL.Context;

namespace portfolio.ViewComponent
{
    public class _SkillsComponentPartial : Microsoft.AspNetCore.Mvc.ViewComponent
    { PortfolioContext portfolioContext = new PortfolioContext();
        public IViewComponentResult Invoke()
        {   var values = portfolioContext.Skills.ToList();
            return View(values);
        }
    }
}
