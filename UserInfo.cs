using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UCDU.Models
{
    public class UserInfo
    {
        [Display(Name = "National Id")]
      //  [MaxLength(14)]
        [Required(ErrorMessage = "Please Make sure to Write the National ID")]
        public long NID { get; set; }

        [Display(Name = "Position Id")]
       // [MaxLength(4)]
        [Required(ErrorMessage = "Please Make sure to Write the Position ID")]

        public int PosId { get; set; }

        [Required(ErrorMessage = "Please Make sure to Write the Authority ID")]

        public int AuthId { get; set; }

        [Required(ErrorMessage = "Please Make sure to write The username")]
        [Display(Name = "Username")]
        public string Uname { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Make sure to ENTER The Password")]
        public string Pwd { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Make sure to ENTER The Confirm Password")]
        [Compare("Pwd")]
        public string ConfirmPwd { get; set; }

        [Required(ErrorMessage = "Please Make sure to write  your name in arabic")]
        [Display(Name = "Name In Arabic ")]
        public string Aname { get; set; }

        [Required(ErrorMessage = "Please Make sure to write  your name in english")]
        [Display(Name = "Name In English ")]
        public string Ename { get; set; }

        [Required(ErrorMessage = "Please Make sure to choose The Date")]
        [Display(Name = "BirthDate ")]
        [DataType(DataType.Date)]
        public string BD { get; set; }

        [Required(ErrorMessage = "Please Make sure to write  your email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required]
        public string Country { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string University { get; set; }
        [Required]
        public string Faculty { get; set; }

        [Required]
        public string PositionVal { get; set; }

        public int IsActive { get; set; }

        public long BillNumber { get; set; }






    }
}