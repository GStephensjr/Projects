using HierarchyGUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace HierarchyGUI.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext context;
        public HomeController(ApplicationDbContext ctx) => context = ctx;
        public IActionResult Index() => View();
        public IActionResult Register() => View();
        public IActionResult Congratulations() => View();

        [HttpPost]
        public IActionResult Register(Authentication response)
        {
            response.Password = HashDirectory.Hash(response.Password);
            context.getAuthentication.Add(response);
            context.SaveChanges();
            return RedirectToAction(nameof(Congratulations),
            new { UserName = response.UserName, Password = response.Password, Admin = response.Admin });
            //return RedirectToAction(nameof(Index));
        }
        //public IActionResult Thanks(GuestResponse response)
        //{
        //    return View(response);
        //}
        public IActionResult ListUsers()
        {
            return View(context.getAuthentication.OrderByDescending(r => r));
        }

    }
}
