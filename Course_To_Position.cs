using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UCDU.Models
{
    public class Course_To_Position
    {
        [Display(Name = "Course Id")]
     
        [Required(ErrorMessage = "Please Make sure to Write the Course ID")]
        public int CID { get; set; }

        [Display(Name = "Position Id")]
       
        [Required(ErrorMessage = "Please Make sure to Write the Position ID")]
        public int PosId { get; set; }

        public bool IsChecked { get; set; }

       
    }

    public class crpList
    {
        public List<Course_To_Position> coursePositionList { get; set; }
    }
}