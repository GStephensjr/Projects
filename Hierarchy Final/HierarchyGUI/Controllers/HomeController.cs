using HierarchyGUI.Models;
using HierarchyGUI.Models.ViewModels;
using HierarchyGUI.Models.IRepositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HierarchyGUI.Models.Database_Models;


namespace HierarchyGUI.Controllers
{
    public class HomeController: Controller
    {
        private ICredentialsRepository repository;
        private IRepository context;

        public HomeController(ICredentialsRepository repo, IRepository ctx)
        {
            repository = repo;
            context = ctx;
        }
        public IActionResult Congratulations() => View();

        public IActionResult Home()=> View();

        //Database Entry Views
        public IActionResult Register() => View();
        public IActionResult Add() => View();
        public IActionResult HeadquartersAFCreate() => View();
        public IActionResult MajcomCreate() => View();
        public IActionResult NumberedAFCreate() => View();
        public IActionResult WingCreate() => View();
        public IActionResult GroupCreate() => View();
        public IActionResult SquadronCreate() => View();
        public IActionResult CongratulationsEntry() => View();


        //Listing Views
        public IActionResult HeadquartersAF() => View(context.HeadquartersAF.Select(r=>r));
        public IActionResult MajcomListing() => View(context.Majcoms.Select(r => r));
        public IActionResult GroupListing() => View(context.Groups.Select(r => r));
        public IActionResult WingListing() => View(context.Wings.Select(r => r));
        public IActionResult SquadronListing() => View(context.Squadrons.Select(r => r));
        public IActionResult NumberedAFListing() => View(context.NumberedAFs.Select(r => r));

        //entry creations
        [HttpPost]
        public IActionResult HeadquartersAFCreate(HeadquartersAF entry)
        {
            context.saveEntry(entry);
            return RedirectToAction(nameof(CongratulationsEntry));
        }
        [HttpPost]
        public IActionResult MajcomCreate(Majcom entry)
        {
            context.saveEntry(entry);
            return RedirectToAction(nameof(CongratulationsEntry));
        }
        [HttpPost]
        public IActionResult NumberedAFCreate(NumberedAF entry)
        {
            context.saveEntry(entry);
            return RedirectToAction(nameof(CongratulationsEntry));
        }
        [HttpPost]
        public IActionResult WingCreate(Wing entry)
        {
            context.saveEntry(entry);
            return RedirectToAction(nameof(CongratulationsEntry));
        }
        [HttpPost]
        public IActionResult GroupCreate(Group entry)
        {
            context.saveEntry(entry);
            return RedirectToAction(nameof(CongratulationsEntry));
        }
        [HttpPost]
        public IActionResult SquadronCreate(Squadron entry)
        {
            context.saveEntry(entry);
            return RedirectToAction(nameof(CongratulationsEntry));
        }






        public IActionResult DeleteHeadquarters(string Name)
        {
            HeadquartersAF dbentry = context.HeadquartersAF.FirstOrDefault(p => p.StaffName == Name);
            context.deleteEntry(dbentry);
            
            return (RedirectToAction(nameof(Home)));
        }
        public IActionResult DeleteMajcom(string Name)
        {
            Majcom dbentry = context.Majcoms.FirstOrDefault(p => p.Name == Name);
            context.deleteEntry(dbentry);

            return (RedirectToAction(nameof(Home)));
        }
        public IActionResult DeleteNumberedAF(string Name)
        {
            NumberedAF dbentry = context.NumberedAFs.FirstOrDefault(p => p.Name == Name);
            context.deleteEntry(dbentry);

            return (RedirectToAction(nameof(Home)));
        }
        public IActionResult DeleteWings(string Name)
        {
            Wing dbentry = context.Wings.FirstOrDefault(p => p.Name == Name);
            context.deleteEntry(dbentry);

            return (RedirectToAction(nameof(Home)));
        }
        public IActionResult DeleteGroup(string Name)
        {
            Group dbentry = context.Groups.FirstOrDefault(p => p.Name == Name);
            context.deleteEntry(dbentry);

            return (RedirectToAction(nameof(Home)));
        }
        public IActionResult DeleteSquadron(string Name)
        {
            Squadron dbentry = context.Squadrons.FirstOrDefault(p => p.Name == Name);
            context.deleteEntry(dbentry);

            return (RedirectToAction(nameof(Home)));
        }





        public IActionResult DeleteUser(string UserName)
        {
            Credential User = repository.Credentials
                .FirstOrDefault(p => p.UserName == UserName);
            repository.deleteUser(User);
            return (RedirectToAction(nameof(ListUsers)));
        }
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

        public IActionResult Logout()
        {
            SessionCredentials.Status = false;
            SessionCredentials.User = null;
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Index() => View();
        public IActionResult test() => View();

        public IActionResult Login() => View();

        //modification views
        public IActionResult ModifyUser(string UserName) => View(repository.Credentials
            .FirstOrDefault(p => p.UserName == UserName));
        public IActionResult ModifyHeadquarters(string Name)=>View(context.HeadquartersAF.FirstOrDefault(p=>p.StaffName == Name));
        public IActionResult ModifyMajcom(string Name) => View(context.Majcoms.FirstOrDefault(p => p.Name == Name));
        public IActionResult ModifyNumberedAF(string Name) => View(context.NumberedAFs.FirstOrDefault(p => p.Name == Name));
        public IActionResult ModifyWing(string Name) => View(context.Wings.FirstOrDefault(p => p.Name == Name));
        public IActionResult ModifyGroup(string Name) => View(context.Groups.FirstOrDefault(p => p.Name == Name));
        public IActionResult ModifySquadron(string Name) => View(context.Squadrons.FirstOrDefault(p => p.Name == Name));

        //modification actions
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
        [HttpPost]
        public IActionResult ModifyHeadquarters(HeadquartersAF entry)
        {
            if (ModelState.IsValid)
            {
                context.saveEntry(entry);
                return RedirectToAction(nameof(CongratulationsEntry));
            }
            else
            {
                // there is something wrong with the data values
                return View(entry);
            }

        }
        [HttpPost]
        public IActionResult ModifyMajcom(Majcom entry)
        {
            if (ModelState.IsValid)
            {
                context.saveEntry(entry);
                return RedirectToAction(nameof(CongratulationsEntry));
            }
            else
            {
                // there is something wrong with the data values
                return View(entry);
            }

        }
        [HttpPost]
        public IActionResult ModifyNumberedAF(NumberedAF entry)
        {
            if (ModelState.IsValid)
            {
                context.saveEntry(entry);
                return RedirectToAction(nameof(CongratulationsEntry));
            }
            else
            {
                // there is something wrong with the data values
                return View(entry);
            }

        }
        [HttpPost]
        public IActionResult ModifyWing(Wing entry)
        {
            if (ModelState.IsValid)
            {
                context.saveEntry(entry);
                return RedirectToAction(nameof(CongratulationsEntry));
            }
            else
            {
                // there is something wrong with the data values
                return View(entry);
            }

        }
        [HttpPost]
        public IActionResult ModifyGroup(Group entry)
        {
            if (ModelState.IsValid)
            {
                context.saveEntry(entry);
                return RedirectToAction(nameof(CongratulationsEntry));
            }
            else
            {
                // there is something wrong with the data values
                return View(entry);
            }

        }
        [HttpPost]
        public IActionResult ModifySquadron(Squadron entry)
        {
            if (ModelState.IsValid)
            {
                context.saveEntry(entry);
                return RedirectToAction(nameof(CongratulationsEntry));
            }
            else
            {
                // there is something wrong with the data values
                return View(entry);
            }

        }





        //entry views
        public IActionResult NumberedAFEntry(string Name) => View(context.NumberedAFs.FirstOrDefault(p => p.Name == Name));
        public IActionResult MajcomEntry(string Name) => View(context.Majcoms.FirstOrDefault(p => p.Name == Name));
        public IActionResult GroupEntry(string Name) => View(context.Groups.FirstOrDefault(p => p.Name == Name));
        public IActionResult WingEntry(string Name) => View(context.Wings.FirstOrDefault(p => p.Name == Name));
        public IActionResult SquadronEntry(string Name) => View(context.Squadrons.FirstOrDefault(p => p.Name == Name));



        [HttpPost]
        public IActionResult Search(string query)
        {
            List<IUnit> Results = new List<IUnit>();
            //MAJCOMSEARCH
            var MajCheck = context.Majcoms.Where(p => p.Name.ToLower().Contains(query.ToLower()));
            if (MajCheck != null)
                foreach(Majcom m in MajCheck)
                    if (!Results.Contains(new IUnit { Name = m.Name, Origin = "Majcom" }))
                        Results.Add(new IUnit
                        {
                            Name = m.Name,
                            Origin = "Majcom"
                        });
            MajCheck = null;
            MajCheck = context.Majcoms.Where(p => p.Commander.ToLower().Contains(query.ToLower()));
            if (MajCheck != null)
                foreach (Majcom m in MajCheck)
                    if (!Results.Contains(new IUnit { Name = m.Name, Origin = "Majcom" }))
                        Results.Add(new IUnit
                        {
                            Name = m.Name,
                            Origin = "Majcom"
                        });
            MajCheck = null;

            MajCheck = context.Majcoms.Where(p => p.Location.ToLower().Contains(query.ToLower()));
            if (MajCheck != null)
                foreach (Majcom m in MajCheck)
                    if (!Results.Contains(new IUnit { Name = m.Name, Origin = "Majcom" }))
                        Results.Add(new IUnit
                        {
                            Name = m.Name,
                            Origin = "Majcom"
                        });
            MajCheck = null;

            MajCheck = context.Majcoms.Where(p => p.Motto.ToLower().Contains(query.ToLower()));
            if (MajCheck != null)
                foreach (Majcom m in MajCheck)
                    if (!Results.Contains(new IUnit { Name = m.Name, Origin = "Majcom" }))
                        Results.Add(new IUnit
                        {
                            Name = m.Name,
                            Origin = "Majcom"
                        });
            MajCheck = null;

            MajCheck = context.Majcoms.Where(p => p.Mission.ToLower().Contains(query.ToLower()));
            if (MajCheck != null)
                foreach (Majcom m in MajCheck)
                    if (!Results.Contains(new IUnit { Name = m.Name, Origin = "Majcom" }))
                        Results.Add(new IUnit
                        {
                            Name = m.Name,
                            Origin = "Majcom"
                        });
            MajCheck = null;

            // NUMSEARCH
            var NumCheck = context.NumberedAFs.Where(p => p.Name.ToLower().Contains(query.ToLower()));
            if (NumCheck != null)
                foreach (NumberedAF m in NumCheck)
                    if(!Results.Contains(new IUnit {Name = m.Name, Origin = "NumberedAF" }))
                        Results.Add(new IUnit
                        {
                            Name = m.Name,
                            Origin = "NumberedAF"
                        });
            NumCheck = null;

            NumCheck = context.NumberedAFs.Where(p => p.Commander.ToLower().Contains(query.ToLower()));
            if (NumCheck != null)
                foreach (NumberedAF m in NumCheck)
                    if (!Results.Contains(new IUnit { Name = m.Name, Origin = "NumberedAF" }))
                        Results.Add(new IUnit
                        {
                            Name = m.Name,
                            Origin = "NumberedAF"
                        });
            NumCheck = null;

            NumCheck = context.NumberedAFs.Where(p => p.Location.ToLower().Contains(query.ToLower()));
            if (NumCheck != null)
                foreach (NumberedAF m in NumCheck)
                    if (!Results.Contains(new IUnit { Name = m.Name, Origin = "NumberedAF" }))
                        Results.Add(new IUnit
                        {
                            Name = m.Name,
                            Origin = "NumberedAF"
                        });
            NumCheck = null;

            NumCheck = context.NumberedAFs.Where(p => p.Majcom.ToLower().Contains(query.ToLower()));
            if (NumCheck != null)
                foreach (NumberedAF m in NumCheck)
                    if (!Results.Contains(new IUnit { Name = m.Name, Origin = "NumberedAF" }))
                        Results.Add(new IUnit
                        {
                            Name = m.Name,
                            Origin = "NumberedAF"
                        });
            NumCheck = null;

            NumCheck = context.NumberedAFs.Where(p => p.Motto.ToLower().Contains(query.ToLower()));
            if (NumCheck != null)
                foreach (NumberedAF m in NumCheck)
                    if (!Results.Contains(new IUnit { Name = m.Name, Origin = "NumberedAF" }))
                        Results.Add(new IUnit
                        {
                            Name = m.Name,
                            Origin = "NumberedAF"
                        });
            NumCheck = null;

            NumCheck = context.NumberedAFs.Where(p => p.Mission.ToLower().Contains(query.ToLower()));
            if (NumCheck != null)
                foreach (NumberedAF m in NumCheck)
                    if (!Results.Contains(new IUnit { Name = m.Name, Origin = "NumberedAF" }))
                        Results.Add(new IUnit
                        {
                            Name = m.Name,
                            Origin = "NumberedAF"
                        });
            NumCheck = null;

            //WINGSEARCH

            var WingCheck = context.Wings.Where(p => p.Name.ToLower().Contains(query.ToLower()));
            if (WingCheck != null)
                foreach (Wing m in WingCheck)
                    if (!Results.Contains(new IUnit { Name = m.Name, Origin = "Wing" }))
                        Results.Add(new IUnit
                        {
                            Name = m.Name,
                            Origin = "Wing"
                        });
            WingCheck = null;

            WingCheck = context.Wings.Where(p => p.Commander.ToLower().Contains(query.ToLower()));
            if (WingCheck != null)
                foreach (Wing m in WingCheck)
                    if (!Results.Contains(new IUnit { Name = m.Name, Origin = "Wing" }))
                        Results.Add(new IUnit
                        {
                            Name = m.Name,
                            Origin = "Wing"
                        });
            WingCheck = null;

            WingCheck = context.Wings.Where(p => p.Location.ToLower().Contains(query.ToLower()));
            if (WingCheck != null)
                foreach (Wing m in WingCheck)
                    if (!Results.Contains(new IUnit { Name = m.Name, Origin = "Wing" }))
                        Results.Add(new IUnit
                        {
                            Name = m.Name,
                            Origin = "Wing"
                        });
            WingCheck = null;
            WingCheck = context.Wings.Where(p => p.Motto.ToLower().Contains(query.ToLower()));
            if (WingCheck != null)
                foreach (Wing m in WingCheck)
                    if (!Results.Contains(new IUnit { Name = m.Name, Origin = "Wing" }))
                        Results.Add(new IUnit
                        {
                            Name = m.Name,
                            Origin = "Wing"
                        });
            WingCheck = null;
            WingCheck = context.Wings.Where(p => p.Mission.ToLower().Contains(query.ToLower()));
            if (WingCheck != null)
                foreach (Wing m in WingCheck)
                    if (!Results.Contains(new IUnit { Name = m.Name, Origin = "Wing" }))
                        Results.Add(new IUnit
                        {
                            Name = m.Name,
                            Origin = "Wing"
                        });
            WingCheck = null;
            WingCheck = context.Wings.Where(p => p.Majcom.ToLower().Contains(query.ToLower()));
            if (WingCheck != null)
                foreach (Wing m in WingCheck)
                    if (!Results.Contains(new IUnit { Name = m.Name, Origin = "Wing" }))
                        Results.Add(new IUnit
                        {
                            Name = m.Name,
                            Origin = "Wing"
                        });
            WingCheck = null;


            //GROUPSEARCH
            var GroupCheck = context.Groups.Where(p => p.Name.ToLower().Contains(query.ToLower()));
            if (GroupCheck != null)
                foreach (Group m in GroupCheck)
                    if (!Results.Contains(new IUnit { Name = m.Name, Origin = "Group" }))
                        Results.Add(new IUnit
                        {
                            Name = m.Name,
                            Origin = "Group"
                        });
            GroupCheck = null;

            GroupCheck = context.Groups.Where(p => p.Commander.ToLower().Contains(query.ToLower()));
            if (GroupCheck != null)
                foreach (Group m in GroupCheck)
                    if (!Results.Contains(new IUnit { Name = m.Name, Origin = "Group" }))
                        Results.Add(new IUnit
                        {
                            Name = m.Name,
                            Origin = "Group"
                        });
            GroupCheck = null;

            GroupCheck = context.Groups.Where(p => p.Location.ToLower().Contains(query.ToLower()));
            if (GroupCheck != null)
                foreach (Group m in GroupCheck)
                    if (!Results.Contains(new IUnit { Name = m.Name, Origin = "Group" }))
                        Results.Add(new IUnit
                        {
                            Name = m.Name,
                            Origin = "Group"
                        });
            GroupCheck = null;

            GroupCheck = context.Groups.Where(p => p.Motto.ToLower().Contains(query.ToLower()));
            if (GroupCheck != null)
                foreach (Group m in GroupCheck)
                    if (!Results.Contains(new IUnit { Name = m.Name, Origin = "Group" }))
                        Results.Add(new IUnit
                        {
                            Name = m.Name,
                            Origin = "Group"
                        });
            GroupCheck = null;

            GroupCheck = context.Groups.Where(p => p.Mission.ToLower().Contains(query.ToLower()));
            if (GroupCheck != null)
                foreach (Group m in GroupCheck)
                    if (!Results.Contains(new IUnit { Name = m.Name, Origin = "Group" }))
                        Results.Add(new IUnit
                        {
                            Name = m.Name,
                            Origin = "Group"
                        });
            GroupCheck = null;

            //SQUADCHECK
            var SquadCheck = context.Squadrons.Where(p => p.Name.ToLower().Contains(query.ToLower()));
            if (SquadCheck != null)
                foreach (Squadron m in SquadCheck)
                    if (!Results.Contains(new IUnit { Name = m.Name, Origin = "Squadron" }))
                        Results.Add(new IUnit
                        {
                            Name = m.Name,
                            Origin = "Squadron"
                        });
            SquadCheck = null;

            SquadCheck = context.Squadrons.Where(p => p.Commander.ToLower().Contains(query.ToLower()));
            if (SquadCheck != null)
                foreach (Squadron m in SquadCheck)
                    if (!Results.Contains(new IUnit { Name = m.Name, Origin = "Squadron" }))
                        Results.Add(new IUnit
                        {
                            Name = m.Name,
                            Origin = "Squadron"
                        });
            SquadCheck = null;

            SquadCheck = context.Squadrons.Where(p => p.Location.ToLower().Contains(query.ToLower()));
            if (SquadCheck != null)
                foreach (Squadron m in SquadCheck)
                    if (!Results.Contains(new IUnit { Name = m.Name, Origin = "Squadron" }))
                        Results.Add(new IUnit
                        {
                            Name = m.Name,
                            Origin = "Squadron"
                        });
            SquadCheck = null;

            SquadCheck = context.Squadrons.Where(p => p.Motto.ToLower().Contains(query.ToLower()));
            if (SquadCheck != null)
                foreach (Squadron m in SquadCheck)
                    if (!Results.Contains(new IUnit { Name = m.Name, Origin = "Squadron" }))
                        Results.Add(new IUnit
                        {
                            Name = m.Name,
                            Origin = "Squadron"
                        });
            SquadCheck = null;

            SquadCheck = context.Squadrons.Where(p => p.Mission.ToLower().Contains(query.ToLower()));
            if (SquadCheck != null)
                foreach (Squadron m in SquadCheck)
                    if (!Results.Contains(new IUnit { Name = m.Name, Origin = "Squadron" }))
                        Results.Add(new IUnit
                        {
                            Name = m.Name,
                            Origin = "Squadron"
                        });
            SquadCheck = null;

            if (query == null)
                query = "this is a null value";

            List<IUnit> Output = Results.Distinct().ToList();
            if (Results != null)
                return View(Output);
            else
                return View();
        }
        


        public ActionResult WelcomePage()
        {
            return View();
        }


    }

}
