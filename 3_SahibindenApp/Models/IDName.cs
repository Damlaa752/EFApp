using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_SahibindenApp.Models
{
    internal abstract class IDName 
    {
        public int ID { get; set; }
        public string Name { get; set; }

        protected IDName(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
