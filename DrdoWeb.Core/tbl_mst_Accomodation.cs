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
    
    public partial class tbl_mst_Accomodation
    {
        public long AccomodationID { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Company_Name { get; set; }
        public Nullable<int> Country { get; set; }
        public string Address { get; set; }
        public string Contact_No { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string rID { get; set; }
        public Nullable<int> TotalRoom { get; set; }
        public Nullable<int> TotalAdultPerson { get; set; }
        public string CheckInDate { get; set; }
        public string CheckOutDate { get; set; }
        public Nullable<System.DateTime> RecInsTime { get; set; }
        public string EmailOTP { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}
