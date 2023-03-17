﻿using System.ComponentModel.DataAnnotations;

namespace RazerCourseDemo.Model
{
    public class Student
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }

        public Course Course { get; set; } // bunu kapatıp alttakini açınca farklı bir veritabanı oluşturuyoruz. O da kullanılabilir

        //public ICollection<Course> Courses { get; set; }

    }
}
