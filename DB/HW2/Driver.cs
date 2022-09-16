using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.HW2
{
    public class Driver
    {
        public string Name { get; set; }
        public Car Car { get; set; }
        public string MobileNumber { get; set; }
        public Driver(string name, Car car, string mobileNumber)
        {
            Name = name;
            Car = car;
            MobileNumber = mobileNumber;
        }
        public Driver() { }
        public override string ToString()
        {
            return $"{Name}, {Car.Brand}, {MobileNumber}";
        }
    }
}
