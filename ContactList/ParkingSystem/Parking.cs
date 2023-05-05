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


    }
}