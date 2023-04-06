using _3_SahibindenApp.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _3_SahibindenApp.Models
{
    internal class Car 
    {
        public int CarID { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public string Who { get; set; }
        public double Price { get; set; }

        public int ColorID { get; set; }
        public string City { get; set; }

        public Car(string model, DateTime year, string who, double price, int colorID, string city) 
        {
            Model = model;
            Year = year;
            Who = who;
            Price = price;
            ColorID = colorID;
            City = city;
        }
    }
}
