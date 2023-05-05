using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.Vehicles
{
    public class Vehicle
    {
        public string Model { get; set; }
        public int ProductionYear { get; set; }
        public Person Owner { get; set; }
        public int Weight { get; set; }
        public int Width { get; set; }
        public string FuelType { get; set; }
        public int PassengersNo { get; set; }

        public Vehicle() { }

        public Vehicle(string model, int productionYear, Person owner, int weight, int width, string fuelType, int passengersNo)
        {
            Model=model;
            ProductionYear=productionYear;
            Owner=owner;
            Weight=weight;
            Width=width;
            FuelType=fuelType;
            PassengersNo=passengersNo;
        }

        public int GetWidth()
        {
            return Width;
        }

        public int GetWeight()
        {
            return Weight;
        }

        public virtual int isEconomic()
        {
            if (FuelType.Equals("electricity"))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

      


    }
}
