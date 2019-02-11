using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCore.Entity.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CurrentGradeId { get; set; }
        public Grade CurrentGrade { get; set; }
        public StudentAddress StudentAddress { get; set; }
        public virtual  ICollection<StudentCourse> StudentCourses { get; set; }
    }

    public class StudentEntityConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasOne(m => m.CurrentGrade)
                .WithMany(g => g.Students)
                .HasForeignKey(s => s.CurrentGradeId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();


            builder.HasOne<StudentAddress>(s => s.StudentAddress)
                .WithOne(ad => ad.Student)
                .HasForeignKey<StudentAddress>(ad => ad.AddressOfStudentId);
        }
    }
}
