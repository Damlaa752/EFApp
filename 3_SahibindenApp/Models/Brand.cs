﻿using _3_SahibindenApp.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_SahibindenApp.Models
{
    internal class Brand : IDName
    {
        public Brand(int brandID, string name) : base(brandID, name)
        {
           
        }
    }
}
