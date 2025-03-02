using Microsoft.AspNetCore.Mvc;

namespace portfolio.ViewComponent.LayoutViewComponent
{
    public class _LayoutHeadComponentPartial :Microsoft.AspNetCore.Mvc.ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
    
}
