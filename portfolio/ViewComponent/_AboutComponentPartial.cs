using Microsoft.AspNetCore.Mvc;
using portfolio.DAL.Context;


namespace portfolio.ViewComponent
{
    public class _AboutComponentPartial : Microsoft.AspNetCore.Mvc.ViewComponent

    {   PortfolioContext portfolioContext = new PortfolioContext();
        public IViewComponentResult Invoke()
        {   ViewBag.aboutTitle = portfolioContext.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription = portfolioContext.Abouts.Select(x => x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetails = portfolioContext.Abouts.Select(x => x.Details).FirstOrDefault();

            var values = portfolioContext.Experiences.ToList(); 
            return View(values);
        }
    }
}
