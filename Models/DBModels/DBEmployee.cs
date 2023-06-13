using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models.DBModels
{
    public class DBEmployee
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PreferredName { get; set; }
        public string JobTitle { get; set; }
        public string Office { get; set; }
        public string Department { get; set; }
        public long PhoneNumber { get; set; }
        public string SkypeId { get; set; }
        public string? EmailAddress { get; set; }
    }
}
