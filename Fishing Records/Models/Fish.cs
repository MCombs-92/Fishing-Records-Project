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
        [StringLength(30)]
        public string Species { get; set; }

        public int? Weight { get; set; }

        [StringLength(30)]
        [Required]
        public string Bait { get; set; }

    }
}