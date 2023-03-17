
using RazerCourseDemo.Data;
using RazerCourseDemo.Model;

namespace RazerCourseDemo.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Courses != null)
            {
                Course = await _context.Courses.ToListAsync();
            }
        }
    }
}
