using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UCDU.Models
{
    public class Price
    {

        [Display(Name = "Price ")]
        [MaxLength(5)]
        [Required(ErrorMessage = "Please Make sure to Write the Price")]
        public string Value { get; set; }

        [Display(Name = "Position Id")]
        [MaxLength(4)]
        [Required(ErrorMessage = "Please Make sure to Write the Position ID")]
        public int PosId { get; set; }

        [Display(Name = "State Id")]
        [MaxLength(4)]
        [Required(ErrorMessage = "Please Make sure to Write the State ID")]
        public int StateId { get; set; }

        [Display(Name = "Degree Id")]
        [MaxLength(2)]
        [Required(ErrorMessage = "Please Make sure to Write the Degree ID")]
        public int DegId { get; set; }

    }
}