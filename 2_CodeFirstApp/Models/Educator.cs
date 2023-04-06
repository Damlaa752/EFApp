using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CodeFirstApp.Models
{
    internal class Educator : Entity
    {
        public Educator() : base()
        {
            
        }
        public Educator(string name, string surname) : base(name, surname)
        {
            
        }
    }
}
