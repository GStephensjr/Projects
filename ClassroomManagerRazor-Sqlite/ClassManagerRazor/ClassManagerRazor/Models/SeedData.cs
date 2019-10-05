using ClassManagerRazor.Pages.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace ClassManagerRazor.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(Microsoft.AspNetCore.Builder.IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
            .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Student.Any())
            {
                context.Student.AddRange(
                new Student
                {
                    fName = "Greg",
                    mName = "David",
                    lName = "Stephens",
                    eMail = "greg.d.stephensjr@outlook.com",
                    gitHub = "github.com/gstephensjr",
                    linkedIn = "linkedin.com/in/gregory-stephens/"
                },
                new Student
                {
                    fName = "Adam",
                    lName = "Francis",
                    eMail = "adam.s.francis@outlook.com",
                    gitHub = "github.com/adamsfrancis",
                    linkedIn = "linkedin.com/in/adamsfrancis/"
                },
                new Student
                {
                    fName = "James",
                    lName = "Smelser",
                    eMail = "james.smelser@outlook.com",
                    gitHub = "github.com/JamesSmelser",
                    linkedIn = "linkedin.com/in/jamessmelser"
                },
                new Student
                {
                    fName = "Sean",
                    lName = "Zitzer",
                    eMail = "sean.m.zitzer@outlook.com",
                    gitHub = "github.com/SeanZitzer",
                    linkedIn = "linkedin.com/in/seanzitzer"
                },
                new Student
                {
                    fName = "Cherif",
                    lName = "Ouedraogo",
                    eMail = "cheriffouedraogo@yahoo.com",
                    gitHub = "github.com/cherifouedraogo",
                    linkedIn = "linkedin.com/in/cherifouedraogo"
                },
                new Student
                {
                    fName = "Yamba",
                    lName = "Ouandaogo",
                    eMail = "yamba.ouandaogo@outlook.com",
                    gitHub = "github.com/yambao",
                    linkedIn = "linkedin.com/in/yambao/"
                },
                new Student
                {
                    fName = "Lorenzo",
                    lName = "Carty",
                    eMail = "lorenzo.carty@outlook.com",
                    gitHub = "github.com/lorenzocarty",
                    linkedIn = "linkedin.com/in/lorenzocarty/"
                },
                new Student
                {
                    fName = "Derek",
                    lName = "Cobb",
                    eMail = "derek.l.cobb@outlook.com",
                    gitHub = "github.com/derekcobb",
                    linkedIn = "linkedin.com/in/derek-l-cobb"
                },
                new Student
                {
                    fName = "Edmundo",
                    lName = "Luna",
                    eMail = "edmundo0luna@gmail.com",
                    gitHub = "github.com/edmundolunajr",
                    linkedIn = "linkedin.com/in/edmundo-luna-jr"
                });
                context.SaveChanges();
            }

        }

    }
}
