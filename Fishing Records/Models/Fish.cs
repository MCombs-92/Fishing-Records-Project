using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fishing_Records.Models {
    public class Fish {

        public Fish() {

        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Species { get; set; }

        [Required]
        [StringLength(50)]
        public string SubSpecies { get; set; }

        public int? Weight { get; set; }

        [StringLength(50)]
        [Required]
        public string BaitStyle { get; set; }

        [StringLength(50)]
        [Required]
        public string BaitDesc { get; set; }

        public bool Markedforremoval { get; set; } = false;


    }
}