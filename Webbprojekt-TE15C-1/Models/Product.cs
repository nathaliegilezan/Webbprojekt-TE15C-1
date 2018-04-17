using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Webbprojekt_TE15C_1.Models
{
    public class Product
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Du måste fylla i namn")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Du måste fylla i en beskrivning.")]
        [StringLength(500, MinimumLength = 10, ErrorMessage = "Beskrivningen måste vara  mellan 10 och 50 tecken lång.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "du måste fylla i ett pris.")]
        [Range(0, 100000, ErrorMessage = "Priset måste vara mellan 0 och 100000kr")]
        public double Price { get; set; }
        public string Imagefile { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }


    }
}