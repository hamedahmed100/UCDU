using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UCDU.Models
{
    public class Wait
    {
        [Display(Name = "National Id")]
       

        [Required(ErrorMessage = "Please Make sure to Write the National ID")]
        public long NID { get; set; }

        [Display(Name = "Course Id")]
      
        [Required(ErrorMessage = "Please Make sure to Write the Course ID")]
        public int CID { get; set; }


        [Required(ErrorMessage = "Please Make sure to choose The Date")]

        [DataType(DataType.Date)]
        public string Date { get; set; }


        public string Title { get; set; }
    }
}