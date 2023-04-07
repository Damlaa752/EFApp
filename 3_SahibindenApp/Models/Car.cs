using _3_SahibindenApp.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _3_SahibindenApp.Models
{
    internal class Car 
    {
        [Key]
        public int ID { get; set; }
        public int BrandID { get; set; }
        public Brand Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Km { get; set; }
        public double Price { get; set; }
        public int ColorID { get; set; }
        public Color Color { get; set; }
        public string City { get; set; }

        public Car()
        {
        }

        public Car(string model, int year, int km, double price, string city)
        {
            Model = model;
            Year = year;
            Km = km;
            Price = price;
            City = city;
        }
    }
}
