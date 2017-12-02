using KhaiJobs.DataAccess;
using KhaiJobs.Entities;
using KhaiJobs.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KhaiJobs.Controllers
{
    public class StudentController : Controller
    {
        MainContext context = new MainContext();
        public ActionResult JobSearch()
        {
            return View();
        }
        public ActionResult MyFavorites()
        {
            return View();
        }
        public ActionResult ViewJobPosting()
        {
            return View();
        }
        public ActionResult StudentProfile()
        {
            var model = new StudentProfileViewModel();
            model.Profile = new student_profiles();
            model.job_type = context.job_types.ToList();
            model.experience_levels = context.experience_levels.OrderBy(x=>x.id).ToList();
            model.education_levels = context.education_levels.ToList();

            return View(model);
        }

    }
}