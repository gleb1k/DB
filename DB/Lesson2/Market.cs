using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Market
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Category { get; set; }

        public Market(string name, string address, string category)
        {
            Name = name;
            Address = address;
            Category = category;
        }   
    }
}
