using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Merch
    {
        public string Artikul { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public Store Store { get; set; }
        public int Count { get; set; }
        public Merch(string artikul, string name, float price, Store store, int count)
        {
            Artikul = artikul;
            Name = name;
            Price = price;
            Store = store;
            Count = count;
        }
    }

}
