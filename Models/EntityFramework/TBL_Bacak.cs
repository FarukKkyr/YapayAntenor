//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YapayAntenor.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;

    public partial class TBL_Bacak
    {
        public int BacakID { get; set; }
        public string BacakResim { get; set; }
        public string BacakHareket { get; set; }
        [AllowHtml]
        public string BacakAciklama { get; set; }
    }
}