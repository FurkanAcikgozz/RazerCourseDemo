using RazerCourseDemo.Model;

namespace RazerCourseDemo.Data
{
    public class AppDbContext :DbContext 
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //Flued Api - Table ismini değiştiriyoruz. Veritabanında tutulacak isim
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("CourseTable");
            modelBuilder.Entity<Student>().ToTable("StudentTable");
        }
    }
}
