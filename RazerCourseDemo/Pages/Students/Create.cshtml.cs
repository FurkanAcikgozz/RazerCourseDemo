
using Microsoft.AspNetCore.Mvc.Rendering;
using RazerCourseDemo.Data;
using RazerCourseDemo.Model;

namespace RazerCourseDemo.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _context;

        public CreateModel(AppDbContext context)
        {
            _context = context;
        }

        public List<SelectListItem> CourseListItems { get; set; } = new List<SelectListItem>();

        [BindProperty]
        public int SelectedCourseId { get; set; }
        public IActionResult OnGet()
        {
            var coursesFromDb = _context.Courses.ToList();
            foreach (var course in coursesFromDb)
            {
                CourseListItems.Add(
                    new SelectListItem
                    {
                        Value = course.Id.ToString(),
                        Text = course.Title
                    }
                    );
            }

            return Page();
        }

        [BindProperty]
        public Student Student { get; set; } = default!;


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Students == null || Student == null)
            {
                return Page();
            }

            var courseSelectedFromDb = _context.Courses.Find(SelectedCourseId);
            if (courseSelectedFromDb != null)
            {
                Student.Course = courseSelectedFromDb;
                _context.Students.Add(Student);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./Index");

        }
    }
}
