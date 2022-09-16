using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Text.Json;

namespace DB.HW2
{
    public class Filters
    {
        public static void ClientFilter(string name, string mobnum, int age, Taxi taxi )
        {
            var goodOrders = taxi.Orders.Where(x => x.Client.Name == name && x.Client.MobileNumber == mobnum && x.Client.Age == age);
            if (goodOrders.Any())
            {
                foreach (var o in goodOrders)
                {
                    var client = o.Client;    
                    Console.WriteLine(client.ToString());
                }
            }
            else
                Console.WriteLine("Client doesn't found :с");
        }
        public static void OrderFilter(int iD, Client client, int price, Taxi taxi)
        {
            var goodOrders = taxi.Orders.Where(x => x.ID == iD && x.Client.Equals(client) && x.Price == price);
            if (goodOrders.Any())
            {
                foreach (var o in goodOrders)
                {
                    Console.WriteLine(o.ToString());
                }
            }
            else
                Console.WriteLine("Order doesn't found :с");
        }
        public static void DriverFilter(string name, Car car, string mobileNumber, Taxi taxi)
        {
            var goodDrivers = taxi.Drivers.Where(x => x.Name == name && x.Car.Brand == car.Brand && x.MobileNumber == mobileNumber);
            if (goodDrivers.Any())
            {
                foreach (var d in goodDrivers)
                {
                    Console.WriteLine(d.ToString());
                }
            }
            else
                Console.WriteLine("Driver doesn't found :с");
        }
    }
}
