using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingTestAPI.DataObjects
{
    class CarOwner : ICarOwner
    {
        public string Name { get; set; }
        public string PlateNumber { get; set; }
    }

    public class FrequentFlyerOwner : ICarOwner
    {
        public string Name { get; set; }

        public string PlateNumber { get; set; }
    }
}
