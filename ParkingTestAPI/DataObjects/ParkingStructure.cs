using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingTestAPI.DataObjects
{
    class ParkingStructure
    {
        public int Levels { get; set; }
        public int SpotsAvailable { get; set; }
        public int SpotsInUse { get; set;}
        public string Types { get; set; }

    }
}
