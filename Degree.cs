using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UCDU.Models
{
    public class Degree
    {
        [Display(Name = "Degree Id")]
        [MaxLength(2)]
        [Required(ErrorMessage = "Please Make sure to Write the Degree ID")]
        public int DegId { get; set; }


        [Display(Name = "Position Id")]
        [MaxLength(2)]
        [Required(ErrorMessage = "Please Make sure to Write the Position ID")]
        public int PosId { get; set; }

        [Display(Name = "Degree")]
        [Required(ErrorMessage = "Please Make sure to Write the Degree ")]
        public string Deg { get; set; }
    }
}