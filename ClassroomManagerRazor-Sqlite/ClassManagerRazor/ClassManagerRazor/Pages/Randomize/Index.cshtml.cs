using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassManagerRazor.Pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ClassManagerRazor.Pages.Randomize
{
    public class IndexModel : PageModel
    {
        private Random Random = new Random();
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
            Students = RandomizeList(Students);
        }

        internal IEnumerable<Student> RandomizeList(IEnumerable<Student> input)
        {
            int acc = 0;
            var source = input.ToList();
            while (acc < 100000)
            {
                int curIndex = Random.Next(0, source.Count());
                var temp = source[curIndex];
                source.RemoveAt(curIndex);
                source.Add(temp);
                acc++;
            }
            Students = source.ToList();
            return Students;
        }
    }
}