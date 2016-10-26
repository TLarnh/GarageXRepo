using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GarageXX.Models {
    public class Vehicle {
        public int Id { get; set; }
        public string RegNr { get; set; }

        [Required(ErrorMessage = "Regnr måste anges!")]
        public string Color { get; set; }
        public DateTime CheckinTime { get; set; }
        public int Tyres { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        public int MemberId { get; set; }
        public virtual Member Member { get; set; }

        public int VehicleTypeId { get; set; }
        public virtual VehicleType VehicleType { get; set; }

    }
}