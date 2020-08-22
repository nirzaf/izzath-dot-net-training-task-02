using ABC_Drive.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Drive.Model
{
    public class Rent
    {
        [Key]
        public int RentId { get; set; }
        [Required]
        public Vehicle Vehicle { get; set; }
        [Required]
        public DateTime RentedDate { get; set; }
        [Required]
        public DateTime ReturnedDate { get; set; }
        public Driver Driver { get; set; }
        public int TotDays { get; set; }
        public int TotDriverCost { get; set; }
        public int TotDaysAmnt { get; set; }
        public int TotWeeksAmnt { get; set; }
        public int TotMonthsAmnt { get; set; }
        public float TotalRent { get; set; }
    }
}
