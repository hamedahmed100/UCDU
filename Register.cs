using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UCDU.Models
{
    public class Register
    {
        [Display(Name = "National Id")]
        
        [Required(ErrorMessage = "Please Make sure to Write the National ID")]
        public long NID { get; set; }

        [Display(Name = "Course Id")]
       
        [Required(ErrorMessage = "Please Make sure to Write the Course ID")]
        public int CID { get; set; }

        [Display(Name = "Bill Number")]
       
        [Required(ErrorMessage = "Please Make sure to Write the Bill Number")]
        public long BillNum { get; set; }

        [Display(Name = "State Id")]
       
        [Required(ErrorMessage = "Please Make sure to Write the State ID")]
        public int StateId { get; set; }

        [Display(Name = "Degree Id")]
       
        [Required(ErrorMessage = "Please Make sure to Write the Degree ID")]
        public int DegId { get; set; }

        [Required(ErrorMessage = "Please Make sure to choose The Date")]
        
        [DataType(DataType.Date)]
        public string Date { get; set; }

        [Required(ErrorMessage = "Please Make sure to choose The Date")]

        [DataType(DataType.Date)]
        public string Times { get; set; }

    }
}