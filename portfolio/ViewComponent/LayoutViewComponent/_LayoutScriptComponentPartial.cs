using Microsoft.AspNetCore.Mvc;
namespace portfolio.ViewComponent.LayoutViewComponent
{
    public class _LayoutScriptComponentPartial: Microsoft.AspNetCore.Mvc.ViewComponent  
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
