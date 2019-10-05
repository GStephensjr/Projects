using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassManagerRazor.Pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClassManagerRazor.Pages.StudentList
{
    public class AddModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public AddModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [TempData]
        public string Message { get; set; }

        [BindProperty]
        public Student Student { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) { return Page(); }
            _db.Student.Add(Student);
            await _db.SaveChangesAsync();
            Message = "Student successfully added to the database.";
            return RedirectToPage("Index");
        }
    }
}