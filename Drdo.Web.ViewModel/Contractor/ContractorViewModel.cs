using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drdo.Web.ViewModel.Contractor
{
   public class ContractorViewModel
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Enter First Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter Last Name")]
        public string LName { get; set; }
        [Required(ErrorMessage = "Enter Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Select Country")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Enter Company Name")]
        public string Comp_Name { get; set; }
        [Required(ErrorMessage = "Enter Designation")]
        public string Designation { get; set; }
        [Required(ErrorMessage = "Enter Mobile")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "Select Category")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Select ID Type")]
        public string ID_Type { get; set; }
        [Required(ErrorMessage = "Enter ID Number")]
        public string ID_Number { get; set; }
        [Required(ErrorMessage = "Select Passport Issue Date")]
        public string Passport_Issue_Date { get; set; }
        [Required(ErrorMessage = "Select Passport Expiry Date")]
        public string Passport_Expiry_Date { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> RecInsTime { get; set; }
        public string SendLink { get; set; }
        [Required(ErrorMessage = "Select Photo")]
        public string Photo_Name { get; set; }
        [Required(ErrorMessage = "Select Photo")]
        public string Photo_Path { get; set; }
        public Nullable<int> Assigned_Quota { get; set; }
        public Nullable<int> Balance_Quota { get; set; }
        public Nullable<int> Processing { get; set; }
        public Nullable<int> Approved { get; set; }
        public Nullable<int> Declined { get; set; }
        public Nullable<int> Printed { get; set; }
        public Nullable<int> Delivered { get; set; }
        public Nullable<bool> IsVerified { get; set; }
    }
}
