using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CodeFirstApp.Models
{
    internal class Course
    {
        public Course(string name, DateTime startDate, DateTime endDate)
        {
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
          
        }

        public Course(string name, DateTime startDate, DateTime endDate, int educatorId) : this(name, startDate, endDate)
        {
            EducatorId = educatorId;
           
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int EducatorId { get; set; }
        public Educator Educator { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
