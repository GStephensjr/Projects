using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassManagerRazor.Pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClassManagerRazor.Pages.StudentList
{
    public class EditModel : PageModel
    {
        private ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [TempData]
        public string Message { get; set; }

        [BindProperty]
        public Student Student { get; set; }

        public async Task OnGet(string id)
        {
            Student = await _db.Student.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var StudentFromDb = await _db.Student.FindAsync(Student.ID);
                StudentFromDb.fName = Student.fName;
                StudentFromDb.mName = Student.mName;
                StudentFromDb.lName = Student.lName;
                StudentFromDb.eMail = Student.eMail;
                StudentFromDb.gitHub = Student.gitHub;
                StudentFromDb.linkedIn = Student.linkedIn;
                await _db.SaveChangesAsync();
                Message = "Student updated successfully.";
                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}