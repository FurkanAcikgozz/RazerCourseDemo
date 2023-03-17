
using RazerCourseDemo.Data;
using RazerCourseDemo.Model;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;

namespace RazerCourseDemo.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;


        public IndexModel (AppDbContext context)
        {
            _context = context;

        }

        public bool KayitMumkun { get; set; }
        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            KayitMumkun = true;
            ViewData["KayitMumkun"] = _context.Courses.Any();
            ViewData["dene"] = true;

            

            if (_context.Students != null)
            {
                Student = await _context.Students.ToListAsync();
            }
        }
    }
}
