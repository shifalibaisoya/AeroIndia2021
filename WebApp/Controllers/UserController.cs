using Drdo.Web.Services.User;
using Drdo.Web.ViewModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace WebApp.Controllers
{
    public class UserController : Controller
    {
        #region Add Service
        private IUser userService;
        public UserController()
        {
            userService = new UserService();

        }
        public UserController(IUser _userService)
        {
            this.userService = _userService;
        }
        #endregion
        // GET: User
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(loginViewModel loginView)
      {
            loginViewModel model = new loginViewModel();
            if(ModelState.IsValid)
            {
                model = userService.LoginUser(loginView);
                #region initiliez session values
                Session["UserDefNo"] = model.Comp_ReferenceNo;
                Session["UComp_Name"] = model.Comp_Name;
                Session["UCountry"] = model.Country;
                #endregion
                FormsAuthentication.SetAuthCookie(model.UserName, false);
               return RedirectToAction("EventForms");
            }
                return View();
        }
        public ActionResult EventForms()
        {
            UserViewModel model = new UserViewModel();
            if(ModelState.IsValid)
            {
                string defNo = Session["UserDefNo"].ToString();
                model = userService.UserBadgelist(defNo);
            }
            return View(model);
        }
    }
}