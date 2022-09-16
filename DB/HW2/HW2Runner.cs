using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Text.Json;

namespace DB.HW2
{
    public class HW2Runner
    {
        public static void Run()
        {  
            Client client1 = new Client("Vasya","893700100101",18);
            Client client2 = new Client("Oleg", "893700200202",16);
            Client client3 = new Client("Igor", "893700100103",20);
            Client client4 = new Client("Leha", "893700200204",60);

            Car car1 = new Car("Priora");
            Car car2 = new Car("Granta");
            Car car3 = new Car("Chetirka");

            Driver driver1 = new Driver("Driver1", car1, "88005553501");
            Driver driver2 = new Driver("Driver2", car2, "88005553502");
            Driver driver3 = new Driver("Driver3", car3 ,"88005553503");
            Driver driver4 = new Driver("Driver4", car3, "88005553504");

            Order order1 = new Order("11:30", 1, client1, 300);
            Order order2 = new Order("22:19", 2, client2, 200);
            Order order3 = new Order("12:30", 3, client3, 100);
            Order order4 = new Order("23:19", 4, client4, 40);

            Taxi taxi1 = new Taxi(new List<Driver> { driver1, driver2 }, "Yandex", new List<Order> { order1,order2 });
            Taxi taxi2 = new Taxi(new List<Driver> { driver3, driver4 }, "Maxim", new List<Order> { order3, order4 });

            DataBase dataBase = new DataBase(new List<Taxi> {taxi1,taxi2});

            //json serialization

            var jsonSerializer = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(dataBase.Taxi[0], jsonSerializer);

            using (StreamWriter wr = new StreamWriter(@"C:\Users\gleb\Desktop\Прога\2КУРС\DB\DB\HW2\taxi.JSON", false))
            {
                wr.WriteLine(jsonString);
            }

            //json deserialization

            var jsonDeserializer = JsonSerializer.Deserialize<Taxi>(new FileStream(@"C:\Users\gleb\Desktop\Прога\2КУРС\DB\DB\HW2\taxi.JSON", FileMode.OpenOrCreate));
            Console.WriteLine($"Taxi Name: {jsonDeserializer?.Name}, Client name in order ID:1 : {jsonDeserializer?.Orders[0].Client.Name}");

            //xml serialization

            var xmlSerializer = new XmlSerializer(typeof(Taxi));
            var fs = new FileStream(@"C:\Users\gleb\Desktop\Прога\2КУРС\DB\DB\HW2\taxi.XML", FileMode.OpenOrCreate);
            xmlSerializer.Serialize(fs, dataBase.Taxi[0]);
            fs.Close();

            //xml deserialization

            var xmlDeserializer = (Taxi)xmlSerializer.Deserialize(new FileStream(@"C:\Users\gleb\Desktop\Прога\2КУРС\DB\DB\HW2\taxi.XML", FileMode.OpenOrCreate));
            Console.WriteLine($"Taxi Name: {xmlDeserializer?.Name}, Client name in order ID:1 : {xmlDeserializer?.Orders[0].Client.Name}");

            Filters.ClientFilter("Vasya", "893700100101", 18, xmlDeserializer);
            Filters.OrderFilter(1, client1, 300, jsonDeserializer);
            Filters.DriverFilter("Driver1", car1, "88005553501", jsonDeserializer);
        }
    }
}
