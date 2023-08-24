namespace ParkingSystem
{
    public class Company
    {
        public string CompanyName { get; set; }
        public int EmployeeNumbers { get; set; }

        public string FoundationYear { get;set; }



        public Company() { }


        public Company(string companyName, int employeeNumbers, string foundationYear)
        {
            CompanyName=companyName;
            EmployeeNumbers=employeeNumbers;
            FoundationYear=foundationYear;
        }



    }
}