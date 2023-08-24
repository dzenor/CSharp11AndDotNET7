using ParkingSystem.Vehicles;

namespace ParkingSystem
{
    public class Parking
    {
        public Parking()
        {
        }

        public Parking(int parkingSpaceNumber, string address, string city, int pricePerHour, int discount, string freeDays, Company ownerCompany)
        {
            ParkingSpaceNumber=parkingSpaceNumber;
            Address=address;
            City=city;
            PricePerHour=pricePerHour;
            Discount=discount;
            FreeDays=freeDays;
            OwnerCompany=ownerCompany;
        }

        public int ParkingSpaceNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int PricePerHour { get; set; }
        public int Discount { get; set; }
        public string FreeDays { get; set; }
        public Company OwnerCompany { get; set; }

        public List<VehicleInfo> VehicleInfos { get; set; } = new List<VehicleInfo>();



        public string addVehicle(Vehicle vehicle, int TimeOfParking)
        {

            if (vehicle != null)
            {
                if (vehicle is Car)
                {
                    VehicleInfos.Add(new VehicleInfo(vehicle, TimeOfParking, true, false, false));
                }
                else if (vehicle is Lorry)
                {
                    VehicleInfos.Add(new VehicleInfo(vehicle, TimeOfParking, false, false, true));
                }
                else
                {
                    VehicleInfos.Add(new VehicleInfo(vehicle, TimeOfParking, false, true, false));
                }
                return "added vehicle";
            }
            
            else
            {
                return "not added vehicle!";
            }
        }

        public void removeVehicle(string IdVehicle)
        {
            foreach (VehicleInfo vehicle in VehicleInfos)
            {
                if (vehicle.Vehicle.Model.Equals(IdVehicle))
                {
                    VehicleInfos.Remove(vehicle);
                }
            }
        }

    }
}