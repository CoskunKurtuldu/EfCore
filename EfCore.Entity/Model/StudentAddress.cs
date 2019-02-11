using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCore.Entity.Model
{

    public class StudentAddress
    {
        public int StudentAddressId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int AddressOfStudentId { get; set; }
        public Student Student { get; set; }

    }
    public class StudentAddressEntityConfiguration : IEntityTypeConfiguration<StudentAddress>
    {
        public void Configure(EntityTypeBuilder<StudentAddress> builder)
        {
            builder.HasOne<Student>(s => s.Student)
                .WithOne(ad => ad.StudentAddress)
                .HasForeignKey<StudentAddress>(ad => ad.AddressOfStudentId);
        }
    }
}
