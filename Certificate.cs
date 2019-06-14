using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UCDU.Models
{
    public class Certificate
    {

        [Display(Name = "National Id")]
        [MaxLength(14)]
        [Required(ErrorMessage = "Please Make sure to Write the National ID")]
        public long NID { get; set; }


        [Display(Name = "Course Id")]
        [MaxLength(14)]
        [Required(ErrorMessage = "Please Make sure to Write the Course ID")]
        public int  CID { get; set; }


        
        [Required(ErrorMessage = "Please Make sure to Write the signature")]
        public string Signature { get; set; }


        [Display(Name = "Bill Number")]
       
        [Required(ErrorMessage = "Please Make sure to Write the Bill Number")]
        public long BillNum { get; set; }

        [Required(ErrorMessage = "Please Make sure to choose The Date")]
        [DataType(DataType.Date)]
        public string Date { get; set; }

        [Required(ErrorMessage = "Please Make sure to choose The Time")]
        [DataType(DataType.Time)]
        public int Time { get; set; }

        [Required(ErrorMessage = "Please Make sure to choose The Certificate")]
        [Display(Name = "Certificate Type ")]
        public string Cert_Type { get; set; }
    }
}