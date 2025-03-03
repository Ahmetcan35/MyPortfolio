using Microsoft.AspNetCore.Mvc;
using portfolio.DAL.Context;
using portfolio.DAL.Entities;   
namespace portfolio.ViewComponent.LayoutViewComponent
{


    public class _LayoutNavbarComponentPartial:Microsoft.AspNetCore.Mvc.ViewComponent
    {   PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
    {
            ViewBag.count = context.ToDoLists.Where(x => x.Status == false).Count();
            var values = context.ToDoLists.Where(x=> x.Status==false).ToList();
            return View(values);
    }
    }
    
}
