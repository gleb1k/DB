using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.HW2
{
    public class Order
    {
        public string CallTime { get; set; }
        public int ID { get; set; }
        public Client Client { get; set; }
        public int Price {get; set; }
        public Order() { }

        public Order(string сallTime, int iD, Client client, int price)
        {
            CallTime = сallTime;
            ID = iD;
            Client = client;
            Price = price;
        }
        public override string ToString()
        {
            return $"{CallTime}, {ID}, {Client}, {Price}";
        }
    }
}
