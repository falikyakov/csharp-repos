using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calendar.WebMvc.Models
{
    public class DtoOmerReq
    {
        public int Yom { get; set; }
        public string Sod1 { get; set; }
        public string Sod2 { get; set; }
        public string Teur { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
    }
}