using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UCDU.Models
{
    public class Position_To_State
    {

        [Display(Name = "Position Id")]
        [MaxLength(4)]
        [Required(ErrorMessage = "Please Make sure to Write the Position ID")]
        public int PosId { get; set; }

        [Display(Name = "State Id")]
        [MaxLength(4)]
        [Required(ErrorMessage = "Please Make sure to Write the State ID")]
        public int StateId { get; set; }
    }
}