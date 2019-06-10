﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarChart.Models
{
    public class CelestialObjects
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int? OrbitedObject { get; set; }
        [NotMapped]
        public List<CelestialObjects> Satellites { get; set; }
        public TimeSpan OrbitalPeriod { get; set; }

    }
}
