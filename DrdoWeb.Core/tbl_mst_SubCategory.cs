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
    
    public partial class tbl_mst_SubCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_mst_SubCategory()
        {
            this.tbl_mst_sub_subcategory = new HashSet<tbl_mst_sub_subcategory>();
        }
    
        public int ID { get; set; }
        public string SubCategoryName { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> RecInsTime { get; set; }
    
        public virtual tbl_mst_Category tbl_mst_Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_mst_sub_subcategory> tbl_mst_sub_subcategory { get; set; }
    }
}
