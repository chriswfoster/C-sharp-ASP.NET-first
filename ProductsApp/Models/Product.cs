using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsApp.Models /// a model is an object that represents the data in your application.
// ASP.NET web api can automatically serialize your model to JSON, xml, or some other format.
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}