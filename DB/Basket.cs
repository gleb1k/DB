using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Basket
    {
        public Client Client { get; set; }
        public string CreateDate { get; set; }
        public string PayDate { get; set; }
        public List<Merch> Merches { get; set; }
        public float summ { get; set; }
        public Basket(Client client, string createDate, string payDate, List<Merch> merches, float summ)
        {
            Client = client;
            CreateDate = createDate;
            PayDate = payDate;
            Merches = merches;
            this.summ = summ;
        }
    }
}
