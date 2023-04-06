using _2_CodeFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CodeFirstApp.Models
{
    internal class Student : Entity
    {
        public Student() : base()
        {

        }
        public Student(string name, string surname) : base(name, surname)
        {

        }
    }
}

