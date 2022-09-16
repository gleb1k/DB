using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.HW2
{
    public class DataBase
    {
        public DataBase(List<Taxi> taxi)
        {
            Taxi = taxi;
        }
        public List<Taxi>  Taxi { get; set; }

    }
}
