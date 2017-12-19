using KhaiJobs.DataAccess;
using KhaiJobs.Entities;
using KhaiJobs.ViewModels;
using Microsoft.AspNet.Identity;
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

        public ActionResult EditProfile()
        {
            return View();
        }
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
        public ActionResult ResumePostings()
        {
            return View();
        }
        public ActionResult ViewProfile()
        {
            return View();
        }
        public ActionResult Competence()
        {
            return View();
        }

        
        [Authorize(Roles = "Student")]
        public ActionResult StudentProfile()
        {
            var model = new StudentProfileViewModel();
            var userId = User.Identity.GetUserId();
            model.Profile = context.student_profiles.Where(x => x.student_id == userId).FirstOrDefault() ?? new student_profiles();
            model.job_type = context.job_types.ToList();
            model.experience_levels = context.experience_levels.OrderBy(x => x.id).ToList();
            model.education_levels = context.education_levels.ToList();

            return View(model);
        }

        [HttpPost]
        public ActionResult StudentProfile(StudentProfileEditViewModel model)
        {
            var job_type = context.job_types.ToList();
            var experience_levels = context.experience_levels.OrderBy(x => x.id).ToList();
            var education_levels = context.education_levels.ToList();
            if (model.id == 0)
            {
                var profile = new student_profiles();
                profile.student_id = User.Identity.GetUserId();
                profile.name = model.name;
                profile.is_relocate = model.is_relocate;
                profile.city = model.city;
                profile.country = model.country;
                profile.description = model.description;
                profile.education_level = education_levels.Where(x=>x.id == model.education_level).FirstOrDefault();
                profile.experience_level = experience_levels.Where(x => x.id == model.experience_level).FirstOrDefault();
                profile.job_type = job_type.Where(x => x.id == model.job_type).FirstOrDefault();
                context.student_profiles.Add(profile);
                context.SaveChanges();
            }
            if(model.id != 0)
            {
                var profile = context.student_profiles.Where(x => x.id == model.id).FirstOrDefault();
                profile.name = model.name;
                profile.is_relocate = model.is_relocate;
                profile.city = model.city;
                profile.country = model.country;
                profile.description = model.description;
                profile.education_level = education_levels.Where(x => x.id == model.education_level).FirstOrDefault();
                profile.experience_level = experience_levels.Where(x => x.id == model.experience_level).FirstOrDefault();
                profile.job_type = job_type.Where(x => x.id == model.job_type).FirstOrDefault();
                context.SaveChanges();
            }
            return RedirectToAction("StudentProfile");
        }

    }
}