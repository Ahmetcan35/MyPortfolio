using Microsoft.AspNetCore.Mvc;
using portfolio.DAL.Context;

namespace portfolio.Controllers
{
    public class InboxController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult Inbox()
        {
            var values = context.Messages.ToList();
            return View(values);
        }


        public IActionResult ChangesToIsReadTrue(int id)
        {
            var value = context.Messages.Find(id);
            value.IsRead = true;
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public IActionResult ChangesToIsReadFalse(int id)
        {
            var value = context.Messages.Find(id);
            value.IsRead = false;
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public IActionResult DeleteMessage(int id)
        {
            var message = context.Messages.Find(id);
            context.Messages.Remove(message);
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public IActionResult MessageDetail(int id)
        {
            var value = context.Messages.Find(id);
            return View("MessageDetail", value);
        }

    }
}