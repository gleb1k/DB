using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.HW2
{
    public class Car
    {
        public string Brand { get; set; }
        public Car(string brand)
        {
            Brand = brand;
        }
        public Car() { }
    }
}
