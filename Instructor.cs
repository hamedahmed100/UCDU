using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UCDU.Models
{
    public class Instructor
    {
        [Display(Name = "National Id")]
        [MaxLength(14)]
        [Required(ErrorMessage = "Please Make sure to Write the National ID")]
        public long NID { get; set; }

        [Display(Name = "Course Id")]
        [MaxLength(4)]
        [Required(ErrorMessage = "Please Make sure to Write the Course ID")]
        public int CID { get; set; }

    }
}