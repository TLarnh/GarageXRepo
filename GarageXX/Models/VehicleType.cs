﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GarageXX.Models {
    public class VehicleType {
        public int Id { get; set; }
        public string Type { get; set; }

        public virtual List<Vehicle> Vehicles { get; set; }
    }
}