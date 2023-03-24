using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Models
{
    public class Employee
    {
        
        [JsonIgnore]
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        public string PreferredName { get; set; }

    //    public string EmailAddress { get; set;}

        public JobTitle JobTitle { get; set; }

        public Office Office { get; set; }

        public Department Department { get; set; }

        [Required]
        public long PhoneNumber { get; set; }

        public string SkypeId { get; set; }
    }
}
