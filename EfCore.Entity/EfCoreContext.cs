using System;
using System.Collections.Generic;
using System.Text;
using EfCore.Entity.Model;
using Microsoft.EntityFrameworkCore;

namespace EfCore.Entity
{
    public class EfCoreContext:DbContext
    {
        public EfCoreContext(DbContextOptions<EfCoreContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentEntityConfiguration());
            modelBuilder.ApplyConfiguration(new StudentAddressEntityConfiguration());
            modelBuilder.ApplyConfiguration(new StudentCourseEntityConfiguration());
        }
    }
}
