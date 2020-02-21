using Drdo.Web.ViewModel.Contractor;
using DrdoWeb.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drdo.Web.Services.Contractor
{
   public class ContractorService:IContractor
    {
        #region Global variable and settings
        private readonly gip_defexpo2020testingEntities _entities;
        public ContractorService()
        {
            _entities = new gip_defexpo2020testingEntities();
        }

        #endregion

        public ContractorViewModel AddContractorDetail(ContractorViewModel model)
        {
            
            try
            {
                TestTable mod = new TestTable();
                mod.Name = model.Name +" "+model.LName;
                mod.LName = model.LName;
                mod.Comp_Name = model.Comp_Name;
                mod.Designation = model.Designation;
                mod.Email = model.Email;
                mod.Country = model.Country;
                mod.Mobile = model.Mobile;
                mod.Category = model.Category;
                mod.ID_Type = model.ID_Type;
                mod.ID_Number = model.ID_Number;
                mod.Passport_Issue_Date = model.Passport_Issue_Date;
                mod.Passport_Expiry_Date = model.Passport_Expiry_Date;
                mod.RecInsTime = System.DateTime.Now;
                mod.Photo_Name = model.Photo_Name;
                mod.Photo_Path = model.Photo_Path;
                if(model.SendLink==null)
                {
                    mod.SendLink = "N";
                }
                else
                {
                    mod.SendLink = model.SendLink;
                }
                _entities.TestTables.Add(mod);
                _entities.SaveChanges();
                return model;
            }

            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }
    }
}
