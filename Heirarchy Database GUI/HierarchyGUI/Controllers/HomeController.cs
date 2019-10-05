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
        public IActionResult Login() => View();
        public IActionResult Index1() => View();


        public IActionResult Congratulations() => View();

        [HttpPost]
        public IActionResult Register(Authentication response)
        {
            response.Password = HashDirectory.Hash(response.Password);
            context.getAuthentication.Add(response);
            context.SaveChanges();
            return RedirectToAction(nameof(Congratulations),
            new { UserName = response.UserName, Password = response.Password, Admin = response.Admin });
        }
        public IActionResult ListUsers()
        {
            return View(context.getAuthentication.OrderByDescending(r => r));
        }
        [HttpPost]
        public ActionResult Login(Authentication login)
        {
            if (ModelState.IsValid)
            {
                login.Password = HashDirectory.Hash(login.Password);
                var user = (from userlist in context.getAuthentication
                            where userlist.UserName == login.UserName && userlist.Password == login.Password
                            select new
                            {
                                userlist.Admin,
                                userlist.UserName
                            }).ToList();
                //var user = db.Where(e => string.Equals(e.UserName, login.UserName) && e=> string.Equals(n.Password, login.password)).Select(new );
                if (user.FirstOrDefault() != null)
                {
                    SessionCredentials.User = user.FirstOrDefault().UserName;
                    //Session["UserName"] = user.FirstOrDefault().UserName;
                    SessionCredentials.Status = user.FirstOrDefault().Admin;
                    return Redirect("/home/welcomepage");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid login credentials.");
                }
            }
            return View(login);
        }

        public ActionResult WelcomePage()
        {
            return View();
        }

    }
}
