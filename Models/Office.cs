﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Office
    {
        public string Id { get; set; }
        public string Name { get; set;}
        public int Count { get; set; }
    }
}
