using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UCDU.Models
{
    public class Position
    {
        [Display(Name = "Position Id")]
       
        [Required(ErrorMessage = "Please Make sure to Write the Position ID")]
        public int PosId { get; set; }

        [Display(Name = "Position ")] 
        [Required(ErrorMessage = "Please Make sure to Write the Position ")]
        public string Pos { get; set; }

        public bool IsChecked { get; set; }
    }

    public class posList
    {
        public List<Position> pList { get; set; }
    }
}