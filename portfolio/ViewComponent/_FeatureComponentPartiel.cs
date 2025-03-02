
using Microsoft.AspNetCore.Mvc;
using portfolio.DAL.Context;

namespace portfolio.ViewComponent
{
    public class _FeatureComponentPartiel : Microsoft.AspNetCore.Mvc.ViewComponent

    {   
        PortfolioContext portfolioContext = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Features.ToList();
            return View(values);
        }
    }
    
}
