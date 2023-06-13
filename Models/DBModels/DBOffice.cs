using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DBModels
{
    public class DBOffice
    {
        public string Id { get; set; }
        public string CountryName { get; set; }
        public int Count { get; set; }

    }
}
