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
    
    public partial class tbl_mst_PassCategory
    {
        public long PassCategoryID { get; set; }
        public string PassCategory { get; set; }
        public Nullable<long> OrganizationID { get; set; }
        public string IsActive { get; set; }
        public Nullable<System.DateTime> RecInsTime { get; set; }
    
        public virtual tbl_mst_Organization tbl_mst_Organization { get; set; }
    }
}
