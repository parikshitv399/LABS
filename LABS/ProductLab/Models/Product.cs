using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductLab.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
    }
}