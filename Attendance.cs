using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace UCDU.Models
{
    public class Attendance
    {
        //@Html.TextBoxFor(m=> m.id,  new { maxlength="10" });
        [Required(ErrorMessage = "Please Make sure to Write the National Id")]
        [Display(Name = "National Id")]
        [MaxLength(14)]
        public long NID { get; set; }

        [Required(ErrorMessage = "Please Make sure to Write the Course Id")]
        [Display(Name = "Course ID")]
        [MaxLength(5)]
        public int CID { get; set; }

        [Required(ErrorMessage = "Please Make sure to Write Attendance")]
        [Display(Name = "Attendance ")]
        [MaxLength(10)]
        public string Attend { get; set; }

        [Required(ErrorMessage = "Please Make sure to choose The Date")]
        [Display(Name = "Date ")]
        [DataType(DataType.Date)]
        public string Date { get; set; }

        [Required(ErrorMessage = "Please Make sure to choose The Time")]
        [Display(Name = "Time ")]
        [DataType(DataType.Time)]
        public int Time { get; set; }



    }
}