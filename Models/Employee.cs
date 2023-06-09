﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Models
{
    public class Employee
    {
        
       
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PreferredName { get; set; }

        public string JobTitleId { get; set; }

        public Office Office { get; set; }

        public Department Department { get; set; }

        public long PhoneNumber { get; set; }

        public string SkypeId { get; set; }

        public string EmailAddress { get; set; }
    }
}
