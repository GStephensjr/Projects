using HierarchyGUI.Models;
using HierarchyGUI.Models.ViewModels;
using HierarchyGUI.Models.IRepositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchyGUI.Controllers
{
    public class HomeController: Controller
    {
        private ICredentialsRepository repository;
        public HomeController(ICredentialsRepository repo)
        {
            repository = repo;
        }
        public IActionResult Congratulations() => View();
        public IActionResult Register() => View();

        [HttpPost]
        public IActionResult Register(Credential response)
        {
            response.Password = HashDirectory.Hash(response.Password);
            repository.saveUser(response);
            return RedirectToAction(nameof(Congratulations),
            new { UserName = response.UserName, Password = response.Password, Admin = response.Admin });
        }
        public IActionResult ListUsers()
        {
            return View(repository.Credentials.OrderByDescending(r => r));
        }
        [HttpPost]
        public ActionResult Login(Credential login)
        {
            if (ModelState.IsValid)
            {
                login.Password = HashDirectory.Hash(login.Password);
                var user = (from userlist in repository.Credentials
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

        [HttpPost]
        public IActionResult ModifyUser(Credential User)
        {
            if (ModelState.IsValid)
            {
                repository.saveUser(User);
                TempData["message"] = $"{User.UserName} has been saved";
                return RedirectToAction(nameof(ListUsers));
            }
            else
            {
                // there is something wrong with the data values
                return View(User);
            }

        }
        public IActionResult Index() => View();
        public IActionResult test() => View();

        public IActionResult Login() => View();
        public IActionResult ModifyUser(string UserName) => View(repository.Credentials
            .FirstOrDefault(p => p.UserName == UserName));




        public ActionResult WelcomePage()
        {
            return View();
        }


    }

}
