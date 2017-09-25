using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingTestAPI.DataObjects;

namespace ParkingTestAPI.BusinessObjects
{
    class ParkedCar : IParkedCar
    {
        public string Level { get; set; }
        public string Type { get; set; }
        public DateTime? TimeIn { get; set; }
        public DateTime? TimeOut {get;set;}
        public double Cost { get; set; }
        
        public double TimeParked(DateTime TimeIn, DateTime TimeOut)
        {
            return (TimeOut - TimeIn).TotalHours;

        }
        public double ParkedCost(DateTime TimeIn, DateTime TimeOut, double Cost)
        {
            return ((TimeOut - TimeIn).TotalHours) * Cost; 
        }


    }
}
