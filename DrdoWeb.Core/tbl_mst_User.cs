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
    
    public partial class tbl_mst_User
    {
        public long UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Comp_ReferenceNo { get; set; }
        public bool IsFirst { get; set; }
        public string Category { get; set; }
        public string IsActive { get; set; }
        public Nullable<int> LoginCount { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public string TempRefNo { get; set; }
        public Nullable<System.DateTime> RecInsTime { get; set; }
    }
}
