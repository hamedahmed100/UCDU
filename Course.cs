using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UCDU.Models
{
    public class Course
    {
        [Display(Name = "Course Id")]

        [Required(ErrorMessage = "Please Make sure to Write the Course ID")]
        public int CID { get; set; }

        [Required(ErrorMessage = "Please Make sure to choose The Course Type")]
        [Display(Name = "Course Type ")]
        public string Cr_Type { get; set; }

        [Required(ErrorMessage = "Please Make sure to Write The Course Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please Make sure to Write The Course Image")]
        public string Img { get; set; }

        [Required(ErrorMessage = "Please Make sure to Write The Course Description")]
        public string Desc { get; set; }

        [Required(ErrorMessage = "Please Make sure to choose The  Start Time")]
        [Display(Name = "Start Time")]
        [DataType(DataType.Time)]
        public string Stime { get; set; }

        [Required(ErrorMessage = "Please Make sure to choose The End Time")]
        [Display(Name = "End Time")]
        [DataType(DataType.Time)]
        public string Etime { get; set; }

        [Required(ErrorMessage = "Please Make sure to choose The Date")]
        [Display(Name = "Start Date ")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]

        [DataType(DataType.Date)]

        public string Sdate { get; set; }

        [Required(ErrorMessage = "Please Make sure to choose The Date")]
        [Display(Name = "End Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]

        [DataType(DataType.Date)]

        public string Edate { get; set; }
        public string Location { get; set; }

        [Required(ErrorMessage = "Please Make sure to choose The Capacity")]

        public int Capacity { get; set; }
        public int IsActive { get; set; }

        public bool Checked { get; set; }


    }

    public class CourseList{
        public List<Course> crsList { get; set; }

       }

   
}