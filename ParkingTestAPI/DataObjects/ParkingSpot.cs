using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingTestAPI.DataObjects
{
    class ParkingSpot
    {
        public string Type { get; set; }
        public string Cost { get; set; }
        public bool InUse { get; set; }
        public int SpotNumber { get; set;  }
    }
}
