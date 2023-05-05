using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem
{
    public class ParkingSys
    {
        public List<Parking> Parkings { get; set; } = new List<Parking>();

        public ParkingSys() { }

        public ParkingSys(List<Parking> parkings)
        {
            Parkings=parkings;
        }
    }
}
