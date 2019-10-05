using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassManagerRazor.Pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ClassManagerRazor.Pages.StudentList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Student> Students { get; set; }

        [TempData]
        public string Message { get; set; }

        public async Task OnGet()
        {
            Students = await _db.Student.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(string ID)
        {
            var student = await _db.Student.FindAsync(ID);
            if (student == null) { return NotFound(); }
            _db.Student.Remove(student);
            await _db.SaveChangesAsync();
            Message = "Student succesfully removed from the database.";
            return RedirectToPage("Index");
        }
    }
}