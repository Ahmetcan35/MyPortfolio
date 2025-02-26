using Microsoft.AspNetCore.Mvc;

namespace portfolio.ViewComponent
{
    public class _NavbarComponentPartial: Microsoft.AspNetCore.Mvc.ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }  
            
    
}
