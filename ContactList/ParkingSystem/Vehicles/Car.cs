using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.Vehicles
{
    public class Car : Vehicle
    {
        public string TypeCar { get; set; }

        public Car() : base() { }

        public Car(string typeCar, string model, int productionYear, Person owner, int weight, int width, string fuelType, int passengersNo) : base(model, productionYear, owner, weight, width, fuelType, passengersNo)
        {
            TypeCar=typeCar;
        }
    }
}
