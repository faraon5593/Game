using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Game.Models
{
    public class UserBuildings
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public Buildings Building { get; set; }
        public int X_pos { get; set; }
        public int Y_pos { get; set; }
        public int Lvl { get; set; }
    }
}