using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drdo.Web.ViewModel.User
{
   public class UserViewModel
    {
        public List<GetPassStatusDetails> _getPStatuslist { get; set; }
    }
    public class GetPassStatusDetails
    {
        public Nullable<long> Comp_Id { get; set; }
        public string Comp_ReferenceNo { get; set; }
        public string Comp_Name { get; set; }
        public int Status_Id { get; set; }
        public Nullable<int> Delivered { get; set; }
        public Nullable<int> Printed { get; set; }
        public Nullable<int> Decliend { get; set; }
        public Nullable<int> Approved { get; set; }
        public Nullable<int> Processing { get; set; }
        public Nullable<int> Balance_Quota { get; set; }
        public Nullable<int> Comp_Country { get; set; }
        public Nullable<int> Category_Id { get; set; }
        public string category_Name { get; set; }
        public Nullable<int> Quota { get; set; }
    }
}
