using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingTestAPI.DataObjects;
using ParkingTestAPI.BusinessObjects; 

namespace ParkingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingStructureService pss = new ParkingTestAPI.BusinessObjects.ParkingStructureService();
            //int leveles, int general spots, int frequentfspots = 10, valet = 10 
            Console.WriteLine("how many lvls");
            string levels = Console.ReadLine();
            Console.WriteLine("how many generalspots");
            string genspots = Console.ReadLine();
            Console.WriteLine("how many frequent flyer spots");
            string ffspots = Console.ReadLine();
            Console.WriteLine("how many valet spots");
            string vspots = Console.ReadLine();

            int _ilevels = 0, _igenspots = 0, _iffspots = 0, _ivspots = 0;
            int.TryParse(levels, out _ilevels);
            int.TryParse(genspots, out _igenspots);
            int.TryParse(ffspots, out _iffspots);
            int.TryParse(vspots, out _ivspots);

            pss.BuildParkingStructure(_ilevels, _igenspots, _iffspots, _ivspots);
            Console.ReadLine(); 
        }
    }
}
