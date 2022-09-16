using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.HW2
{
    public class Taxi
    {
        public string Name { get; set; }
        //Свободные водители
        public List<Driver> Drivers { get; set; } 
        public List<Order> Orders { get; set; }
        public Taxi(List<Driver> drivers, string name, List<Order> orders)
        {
            Drivers = drivers;
            Name = name;
            Orders= orders;
        }
        public Taxi() { }

    }
}
