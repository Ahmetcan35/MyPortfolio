using Microsoft.AspNetCore.Mvc;
using portfolio.DAL.Context;
using portfolio.DAL.Entities;

namespace portfolio.Controllers
{
    public class ToDoListController : Controller
    {   PortfolioContext context = new PortfolioContext();
        public IActionResult Index()
        {   var values = context.ToDoLists.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult NewToDoList()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewToDoList(ToDoList toDoList)
        {   toDoList.Status = false;
            context.ToDoLists.Add(toDoList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteToDoList(int id)
        {
            var value = context.ToDoLists.Find(id);
            context.ToDoLists.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateToDoList(int id)
        {
            var value = context.ToDoLists.Find(id);
            return View("UpdateToDoList", value);
        }
        [HttpPost]
        public IActionResult UpdateToDoList(ToDoList toDoList)
        {
           context.ToDoLists.Update(toDoList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }   
        public IActionResult ChangesToDo(int id)
        {
            var value = context.ToDoLists.Find(id);
            value.Status = !value.Status;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}
