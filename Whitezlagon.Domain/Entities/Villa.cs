﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteLagon.Domain.Entities
{
    public class Villa
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public int Sqft { get; set; }
        public int Occupency { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        // Additional properties can be added as needed
    }
}
