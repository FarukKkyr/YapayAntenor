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

    public partial class TBL_Kol
    {
        public int KolID { get; set; }
        public string Resim { get; set; }
        public string Hareket { get; set; }
        [AllowHtml]
        public string Aciklama { get; set; }
    }
}