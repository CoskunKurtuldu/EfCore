using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCore.Entity.Model
{
    public class StudentCourse
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
    public class StudentCourseEntityConfiguration : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.HasKey(sc => new { sc.StudentId, sc.CourseId });
            builder.HasOne<Student>(sc => sc.Student)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.StudentId);

            builder.HasOne<Course>(sc => sc.Course)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.CourseId);


        }
    }
}
