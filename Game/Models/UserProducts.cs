using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Game.Models
{
    public class UserProducts
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public Products Product { get; set; }
        public string ProductName { get; set; }
        public int Value { get; set; }
    }
}