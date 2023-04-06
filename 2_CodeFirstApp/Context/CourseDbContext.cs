using _2_CodeFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CodeFirstApp.Context
{
    internal class CourseDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Educator> Educators { get; set; }
        public DbSet<Course> Courses { get; set; }
       // public CourseDbContext() : base ("CourseDbContext")
       // {
       //     
       // }
    }
}
