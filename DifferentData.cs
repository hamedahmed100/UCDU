using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UCDU.Models
{
    public class DifferentData
    {
        public long NID { get; set; }

        public string Aname { get; set; }


        public string Date { get; set; }


        public string Faculty { get; set; }


        public string Deg { get; set; }


        public long BillNum { get; set; }

        public bool IsChecked { get; set; }
    }

    public class diffdataList
    {
        public List<DifferentData> dList { get; set; }
    }
}