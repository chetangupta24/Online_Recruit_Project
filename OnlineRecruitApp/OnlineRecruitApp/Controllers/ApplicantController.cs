using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using OnlineRecruitApp.Core;
using OnlineRecruitApp.Models;
using System.Data;
using System.Web.Security;

namespace OnlineRecruitApp.Controllers
{
    public class ApplicantController : Controller
    {
        private IAppRepository _applicantRepository;

        public ApplicantController()
        {
            this._applicantRepository = new AppRepository(new ProfileContext());
        }

        public ActionResult Index()
        {
            return View();
        }

        // Get method Action to show a view page for adding a New Applicant
        public ActionResult AddApplicant()
        {
            return View();
        }

        // a json model to save the data through model into the database after communicating the JS files in Scripts/angularJS folder
        public JsonResult save(ApplicantsProfile ap)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _applicantRepository.InsertApplicant(ap);
                    _applicantRepository.Save();
                    return Json("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return Json(ap);
        }

        public ActionResult ApplicantDetails()
        {
            return View();
        }
        // returns a json model to show list of all newly added Applicants 
        public JsonResult Applicantlist()
        {
            var applicants = from ApplicantsProfile in _applicantRepository.GetApplicants()
                             select ApplicantsProfile;
            return Json(applicants, JsonRequestBehavior.AllowGet);
        }
    }
}
