using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1A.Models
{
    public class Car
    {

        [Key]
        public int ID { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        [Range(1980, 2020)]
        public int Year { get; set; }
        [Required]
        [StringLength(17, MinimumLength = 17)]
        public string VIN { get; set; }
        //optional
        public string Color { get; set; }

        public int DealershipID { get; set; }



    }
}
