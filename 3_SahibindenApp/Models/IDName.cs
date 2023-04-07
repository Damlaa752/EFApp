using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_SahibindenApp.Models
{
    internal abstract class IDName 
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

        protected IDName(string name)
        {
            
            Name = name;
        }

        protected IDName()
        {
        }
    }
}
