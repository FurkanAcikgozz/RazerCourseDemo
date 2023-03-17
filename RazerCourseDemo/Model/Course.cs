using System.ComponentModel.DataAnnotations;

namespace RazerCourseDemo.Model
{
    public class Course
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string Title { get; set; }
        public int Credits { get; set; }

        // ICollection ?????????????????????????
        public ICollection<Student> Students { get; set; } = new List<Student>();


        // Üstteki kodun sql script çıktısı aşağıdaki gibidir

        // CONSTRAINT[FK_Students_Courses_CourseId] FOREIGN KEY([CourseId]) REFERENCES[Courses] ([Id]) ON DELETE CASCADE
        // ilişkisel veritabanları. (Tablolar arası) (object relation maping)


        // NOT: CREATE INDEX [IX_Students_CourseId] ON [Students] ([CourseId]); INDEX????????????????????????

    }
}
