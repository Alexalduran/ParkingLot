using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingTestAPI.DataObjects
{
    interface IParkingSpot
    {
        string Type { get; set; }
        string Cost { get; set; }
        bool InUse { get; set; }
    }
}
