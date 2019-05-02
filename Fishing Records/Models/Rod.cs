using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fishing_Records.Models {
    public class Rod {

        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Make { get; set; }

        [Required]
        [StringLength(30)]
        public string Model { get; set; }

        [Required]
        [StringLength(30)]
        public string Power { get; set; }

        [Required]
        [StringLength(30)]
        public string Action { get; set; }


    }
}