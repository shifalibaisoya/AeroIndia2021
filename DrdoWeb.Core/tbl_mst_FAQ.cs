//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DrdoWeb.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_mst_FAQ
    {
        public int FAQId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string Category { get; set; }
        public string CollapsID { get; set; }
        public string IsActive { get; set; }
        public string IsApproved { get; set; }
        public Nullable<System.DateTime> RecInsTime { get; set; }
    }
}
