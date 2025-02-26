using Microsoft.AspNetCore.Mvc;

namespace portfolio.ViewComponent
{
    public class _ContactComponentPartial:Microsoft.AspNetCore.Mvc.ViewComponent    

    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
