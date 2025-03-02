using Microsoft.AspNetCore.Mvc;
namespace portfolio.ViewComponent.LayoutViewComponent
{


    public class _LayoutNavbarComponentPartial:Microsoft.AspNetCore.Mvc.ViewComponent
    {
    public IViewComponentResult Invoke()
    {
        return View();
    }
    }
    
}
