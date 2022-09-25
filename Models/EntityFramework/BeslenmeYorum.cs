using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YapayAntenor.Models.EntityFramework
{
    public class BeslenmeYorum
    {
        public IEnumerable<TBL_Beslenme> Deger1 { get; set; }
        public IEnumerable<TBL_Yorumlar> Deger2 { get; set; }
    }
}