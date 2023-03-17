namespace Model
{
    public class Employee
    { 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAdress { get; set; }
        public JobTitle JobTitle { get; set; }
        public Office Office { get; set; }
        public Department Department { get; set; }  
        public long PhoneNumber { get; set; }
        public string SkypeId { get; set; }
        public string PreferredName { get; set; }

    }
}