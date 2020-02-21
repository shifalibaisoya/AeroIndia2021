using Drdo.Web.ViewModel.Contractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drdo.Web.Services.Contractor
{
    public interface IContractor
    {
        ContractorViewModel AddContractorDetail(ContractorViewModel model);
    }
}
