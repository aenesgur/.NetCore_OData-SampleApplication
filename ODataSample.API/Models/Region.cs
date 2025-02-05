﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODataSample.API.Models
{
    public class Region
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
        public List<Country> Countries { get; set; }
    }
}
