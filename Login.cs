using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UCDU.Models
{
    public class Login
    {


        [Required(ErrorMessage = "Please Enter UserName")]
        [DataType(DataType.Text, ErrorMessage = "Please Enter UserName")]
        public string UNAME { get; set; }


        [Required(ErrorMessage = "Please Enter Password")]
        [DataType(DataType.Password, ErrorMessage = "Please Enter valid Password")]
        [Display(Name = "Password")]
        public string PWD { get; set; }
    }
}