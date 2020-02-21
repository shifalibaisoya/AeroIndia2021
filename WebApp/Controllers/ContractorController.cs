using Drdo.Web.ExternalServices.Email;
using Drdo.Web.Services.Contractor;
using Drdo.Web.Services.User;
using Drdo.Web.ViewModel.Contractor;
using Drdo.Web.ViewModel.User;
using DrdoWeb.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class ContractorController : Controller
    {
        #region Add Service
        private IContractor contractorService;
        private IUser userService;
        public ContractorController()
        {
            contractorService = new ContractorService();
            userService = new UserService();

        }
        public ContractorController(IContractor _contractorService,IUser _userService)
        {
            this.contractorService = _contractorService;
            this.userService = _userService;
        }
        #endregion
        // GET: Contractor
        public ActionResult ContractorBadge()
        {
            UserViewModel model = new UserViewModel();
            if (ModelState.IsValid)
            {
                string defNo = Session["UserDefNo"].ToString();
                model = userService.UserBadgelist(defNo);
            }
            return View(model);
        }
        public ActionResult AddContractorBadge()
        {
            using (gip_defexpo2020testingEntities db = new gip_defexpo2020testingEntities())
            {
                var countryList = db.tbl_mst_Country.ToList<tbl_mst_Country>();
                ViewBag.List = new SelectList(countryList, "CountryID", "CountryName");
                
            }

            return View();
        }[HttpPost]
        public ActionResult AddContractorBadge(ContractorViewModel model)
        {
            using (gip_defexpo2020testingEntities db = new gip_defexpo2020testingEntities())
            {
                var countryList = db.tbl_mst_Country.ToList<tbl_mst_Country>();
                ViewBag.List = new SelectList(countryList, "CountryID", "CountryName");

            }
            model.LName= Session["UserDefNo"].ToString();
            ContractorViewModel mod = new ContractorViewModel();
            if(!ModelState.IsValid)
            {
                if (Request.Files.Count > 0)
                {
                    HttpPostedFileBase file = Request.Files[0];
                    if (file.ContentLength > 0)
                    {
                        var fileName = Path.GetFileName(file.FileName);
                        var FinalFileName =  DateTime.Now.ToString("HHmmss") + "_" + fileName;
                        model.Photo_Path = Path.Combine(
                            Server.MapPath("/assets/Photo/"), FinalFileName);
                        file.SaveAs(model.Photo_Path);
                        model.Photo_Path = "/assets/Photo/" + FinalFileName;
                    }
                    else
                    {
                    }
                    
                }
                mod = contractorService.AddContractorDetail(model);
            }
            return View();
        }
        public ActionResult SendLinkContractorBadge()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SendLinkContractorBadge(ContractorViewModel model)
        {
            //model.LName = Session["UserDefNo"].ToString();
            model.SendLink = "Y";
            ContractorViewModel mod = new ContractorViewModel();
            if (!ModelState.IsValid)
            {
              mod = contractorService.AddContractorDetail(model);
                string mailPath = System.IO.File.ReadAllText(Server.MapPath(@"~/EmailHelper/mailFormat.html"));
                EmailHelper.SendOTPDetails(model, model.Name, mailPath);
            }
            return View();
        }
    }
}