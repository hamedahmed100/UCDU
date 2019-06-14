using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace UCDU.Models
{
    public class Authority
    {
        

        [Required(ErrorMessage = "Please Make sure to Write the Authority ID")]
        public int AuthId { get; set; }

        [Required(ErrorMessage = "Please Make sure to choose the Authority ")]
        public string Auth { get; set; }
    }
}