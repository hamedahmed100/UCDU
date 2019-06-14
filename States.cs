using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UCDU.Models
{
    public class States
    {
        [Display(Name = "State Id")]
        [MaxLength(4)]
        [Required(ErrorMessage = "Please Make sure to Write the State ID")]
        public int StateId { get; set; }
        [Display(Name = "State Name")]
       
        [Required(ErrorMessage = "Please Make sure to Write the State Name")]
        public string StateName { get; set; }

    }
}