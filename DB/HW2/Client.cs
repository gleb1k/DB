using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.HW2
{
    public class Client
    {
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public int Age { get; set; }

        public Client(string name, string mobnum, int age)
        {
            Name = name;
            MobileNumber = mobnum;
            Age = age;
        }
        public Client() { }
        public override string ToString()
        {
            return $"Name: {Name}, MobNum: {MobileNumber}, Age: {Age}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            bool result = false;
            if (obj is Client)
            {
                var client = obj as Client;
                if (client.Name == Name && client.MobileNumber == MobileNumber && client.Age == Age)
                    result = true;
                else
                    result = false;
            }
            return result;
        }
    }
}
