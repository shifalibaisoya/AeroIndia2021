using Drdo.Web.ViewModel.User;
using DrdoWeb.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drdo.Web.Services.User
{
   public class UserService:IUser
    {
        #region Global variable and settings
        
        private readonly gip_defexpo2020testingEntities _entities;
        public UserService()
        {
            _entities = new gip_defexpo2020testingEntities();
        }
        #endregion
        public loginViewModel LoginUser(loginViewModel model)
        {
            loginViewModel loginView = new loginViewModel();
            try
            {
                var isUserexist = _entities.tbl_mst_User.Where(x => x.UserName == model.UserName && x.TempRefNo == model.Password).FirstOrDefault();
                if (isUserexist != null)
                {
                    loginView.Comp_ReferenceNo = isUserexist.Comp_ReferenceNo;
                    loginView.UserName = isUserexist.UserName;
                }
                var IsUser = _entities.tbl_mst_Company.Where(x => x.Comp_ReferenceNo == loginView.Comp_ReferenceNo).FirstOrDefault();
                {
                    loginView.Comp_Name = IsUser.Comp_Name;
                    loginView.Country = IsUser.tbl_mst_Country.CountryName;
                }
                return loginView;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }

        public UserViewModel UserBadgelist(string defNo)
        {
            UserViewModel model = new UserViewModel();
            List<GetPassStatusDetails> list = new List<GetPassStatusDetails>();
            try
            {

                var isUserexist = _entities.vw_PassStatus.Where(x => x.Comp_ReferenceNo ==defNo).ToList();
                foreach(var item in isUserexist)
                {
                    GetPassStatusDetails getPass = new GetPassStatusDetails();
                    getPass.category_Name = item.category_Name;
                    getPass.Quota = item.Quota;
                    getPass.Balance_Quota = item.Balance_Quota;
                    getPass.Processing = item.Processing;
                    getPass.Approved = item.Approved;
                    getPass.Decliend = item.Decliend;
                    getPass.Printed = item.Printed;
                    getPass.Delivered = item.Delivered;
                    list.Add(getPass);
                }
                model._getPStatuslist = list;
                return model;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }
    }
}
