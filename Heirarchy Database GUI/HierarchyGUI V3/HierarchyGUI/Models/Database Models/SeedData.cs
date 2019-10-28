using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace HierarchyGUI.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
            .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Credentials.Any())
            {
                context.Credentials.AddRange(
                new Credential
                {
                    UserName = "admin",
                    Admin = true,
                    Password = HashDirectory.Hash("admin")
                });
                context.SaveChanges();
            }

        }
    }
}
