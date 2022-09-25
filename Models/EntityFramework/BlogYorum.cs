using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YapayAntenor.Models.EntityFramework
{
    public class BlogYorum
    {
        public IEnumerable<TBL_Blog> Deger1 { get; set; }
        public IEnumerable<TBL_Yorumlar> Deger2 { get; set; }
    }
}