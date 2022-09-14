using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Store
    {
        public Market Market { get; set; }
        public string Addres { get; set; }
        public Store(Market market, string addres)
        {
            Market = market;
            Addres = addres;
        }
    }
}
