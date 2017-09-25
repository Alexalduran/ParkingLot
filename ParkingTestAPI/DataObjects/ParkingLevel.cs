using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingTestAPI.DataObjects
{
    class ParkingLevel :IParkingLevel
    {
       public string Level { get; set; }
       public int Spots { get; set;  }
       public int FrequentFlyerSpots { get; set; }
       
    }
}
