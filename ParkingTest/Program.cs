using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingTestApi.DataObject;
using ParkingTestApi.BizObject;

namespace ParkingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingStructureService pss = new ParkingStructureService();
            //int levels, int generalSpots, int frequentFlyerSpots = 10, int valetSpots = 10
            Console.WriteLine("How many levels?");
            string levels = Console.ReadLine();
            Console.WriteLine("How many General Spots?");
            string genspots = Console.ReadLine();
            Console.WriteLine("How many Frequent Flyer Spots?");
            string ffspots = Console.ReadLine();
            Console.WriteLine("How many Valet Spots?");
            string vspots = Console.ReadLine();

            int _ilevels = 0, _igenspots = 0, _iffspots = 0, _ivspost = 0;
            int.TryParse(levels, out _ilevels);
            int.TryParse(genspots, out _igenspots);
            int.TryParse(ffspots, out _iffspots);
            int.TryParse(vspots, out _ivspost);

            //pss.BuildParkingStructure(_ilevels, _igenspots, _iffspots, _ivspost);

            Console.ReadLine();
        }
    }
}
