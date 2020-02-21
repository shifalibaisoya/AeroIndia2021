using Drdo.Web.ViewModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drdo.Web.Services.User
{
   public interface IUser
    {
        loginViewModel LoginUser(loginViewModel model);
        UserViewModel UserBadgelist(string defNo);
    }
}
