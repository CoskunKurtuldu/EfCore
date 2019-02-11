using System;
using System.Collections.Generic;
using System.Text;

namespace EfCore.Entity.Model
{
    public class Grade
    {
        public int Id { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
