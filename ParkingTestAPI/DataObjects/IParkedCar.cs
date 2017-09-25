using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingTestAPI.DataObjects
{
    interface IParkedCar
    {
        string Level { get; set; }
        string Type { get; set; }
        DateTime? TimeIn { get; set; }
        DateTime? TimeOut { get; set; }
        double Cost { get; set; }

        double TimeParked(DateTime TimeIn, DateTime TimeOut); 
    }
}
