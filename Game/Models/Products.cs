using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Game.Models
{
    public class Products
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price_per_unit { get; set; }
        public string Unit { get; set; }
    }
}