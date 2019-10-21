using HierarchyGUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchyGUI.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext context;
        public HomeController(ApplicationDbContext ctx) => context = ctx;
        public IActionResult Index() => View();
        public IActionResult Register() => View();
        public IActionResult test() => View();

        public IActionResult Login() => View();
        public IActionResult ModifyUser(string UserName) => View(context.Credentials
            .FirstOrDefault(p => p.UserName == UserName));


        public IActionResult Congratulations() => View();

        [HttpPost]
        public IActionResult Register(Credential response)
        {
            response.Password = HashDirectory.Hash(response.Password);
            context.Credentials.Add(response);
            context.SaveChanges();
            return RedirectToAction(nameof(Congratulations),
            new { UserName = response.UserName, Password = response.Password, Admin = response.Admin });
        }
        public IActionResult ListUsers()
        {
            return View(context.Credentials.OrderByDescending(r => r));
        }
        [HttpPost]
        public ActionResult Login(Credential login)
        {
            if (ModelState.IsValid)
            {
                login.Password = HashDirectory.Hash(login.Password);
                var user = (from userlist in context.Credentials
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


        [BindProperty]
        public Credential User { get; set; }

        public async Task OnGet(string UserName) { User = await context.Credentials.FindAsync(User.UserName); }

        [HttpPost]
        public async Task<ActionResult> ModifyUser(Credential User)
        {
            if (ModelState.IsValid)
            {
                var dbUser = new Credential(); 
                    dbUser = await context.Credentials.FindAsync(User.UserName);
                dbUser.UserName = User.UserName;
                dbUser.Admin = User.Admin;
                await context.SaveChangesAsync();
                TempData["message"] = $"{User.UserName} has been saved";
                return RedirectToAction(nameof(ListUsers));
            }
            else
            {
                // there is something wrong with the data values
                return View(User);
            }

        }

    }
}
