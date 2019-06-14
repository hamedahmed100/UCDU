using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UCDU.Models
{
    public class History
    {
        public int Cid { get; set; }
        public string Title  { get; set; }
        public string Dates { get; set; }
        public string Times { get; set; }
        public string Location { get; set; }
        public float Price { get; set; }
    }
}