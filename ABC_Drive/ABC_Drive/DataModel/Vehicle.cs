
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Drive.Model
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }
        [Required]
        public string VehicleNo { get; set; }
        [Required]
        public string VehicleName { get; set; }
        [Required]
        public int RatePerDay { get; set; }
        [Required]
        public int RatePerWeek { get; set; }
        [Required]
        public int RatePerMonth { get; set; }

        public ICollection<Rent> Rents { get; set; }
    }
}
