using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Models
{
    public class Employee
    {
        
       
        public string? Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string? PreferredName { get; set; }

        public string JobTitle { get; set; }

        public string Office { get; set; }

        public string Department { get; set; }

        public long PhoneNumber { get; set; }

        public string SkypeId { get; set; }

        public string EmailAddress { get; set; }
    }
}
