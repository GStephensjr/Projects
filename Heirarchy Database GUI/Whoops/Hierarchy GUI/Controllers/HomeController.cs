using Hierarchy_GUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Hierarchy_GUI.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext context;
        public HomeController(ApplicationDbContext ctx) => context = ctx;
        public IActionResult Index() => View();
        public IActionResult Respond() => View();
        [HttpPost]
        public IActionResult Respond(ApplicationDbContext response)
        {
            context.Responses.Add(response);
            context.SaveChanges();
            return RedirectToAction(nameof(Thanks),
            new { Name = response.Name, WillAttend = response.WillAttend });
        }
        public IActionResult Thanks(GuestResponse response)
        {
            return View(response);
        }
        public IActionResult ListUsers()
        {
            return View(context.getAuthentication.UserName.OrderByDescending());
        }

    }
}
