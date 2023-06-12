namespace Person_D.models
{
    public class Personal
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string Gender { get; set; }

        public string Province { get; set; }
    }

    public class GetInvolved
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string CellNum { get; set; }
        public string Message { get; set; }
    }
    public class Sell
    {
        public string ModelName { get; set; }
        public string EngineCapacity { get; set; }
        public int YearModel { get; set; }
        public string Mileage { get; set; }
        public string Transmission { get; set; }
        public string Color { get; set; }
        public string Condition { get; set; }
        public string FuelType { get; set; }
        public string Price { get; set; }
        public string Message { get; set; }

    }

    public class TestDrive
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
         public string Date { get; set; }
        public string Time { get; set; }

    }
}
