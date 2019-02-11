using System;
using System.Collections.Generic;
using System.Text;

namespace EfCore.Entity.Model
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
