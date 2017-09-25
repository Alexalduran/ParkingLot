using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingTestAPI.DataObjects
{
    interface IParkingLevel
    {
        string Level { get; set; }
        int Spots { get; set; }
        int FrequentFlyerSpots { get; set; }
    }
}
