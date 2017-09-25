using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingTestAPI.DataObjects;

namespace ParkingTestAPI.BusinessObjects
{
   public class ParkingStructureService
    {
        public ParkingStructureService()
        {
            ParkingStructure = new Dictionary<string, List<ParkingSpot>>();
        }
        Dictionary<string, List<ParkingSpot>> ParkingStructure; 

        public void ParkCar (string Name, string PlateNumber, string Type, int SpotNumber, string Level)
        {

        }
        public void BuildParkingStructure(int levels, int generalSpots, int frequentFlyerSpots = 10, int valetSpots = 10)
        {
            Console.WriteLine($"Levels:{levels}, General Spots: {generalSpots}, Frequent Flyer Spots: {frequentFlyerSpots}, Valet Spots: {valetSpots}");
            Console.WriteLine($"Total Spots: {(generalSpots + frequentFlyerSpots + valetSpots) * levels}");
        }

    }
}
