using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Game.Models
{
    public class Buildings
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Percent_price_per_lvl { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Product_per_h { get; set; }
        public int Destr_price { get; set; }
        public int Percent_product_per_lvl { get; set; }
    }
}