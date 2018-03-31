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
            var model = new StudentProfileViewModel();
            var userId = User.Identity.GetUserId();
            model.Profile = context.student_profiles.Where(x => x.student_id == userId).FirstOrDefault() ?? new student_profiles();

            return View(model);
        }
        [HttpPost]
        public ActionResult EditProfile(StudentProfileEditViewModel model)
        {
            if (model.id == 0)
            {
                var profile = new student_profiles();
                profile.student_id = User.Identity.GetUserId();
                profile.name = model.name;
                profile.lastname = model.lastname;
                profile.email = model.email;
                profile.phone = model.phone;
                context.student_profiles.Add(profile);
                context.SaveChanges();
            }
            if (model.id != 0)
            {
                var profile = context.student_profiles.Where(x => x.id == model.id).FirstOrDefault();
                profile.name = model.name;
                profile.lastname = model.lastname;
                profile.email = model.email;
                profile.phone = model.phone;
                context.SaveChanges();
            }
            return RedirectToAction("ViewProfile");
        }
        public ActionResult JobSearch(string keyword)
        {
            var model = new VacancySearchViewModel();
            model.Vacancies = new List<vacancy>();
            if (!string.IsNullOrEmpty(keyword))
            {
                var vacancies = context.vacancies.ToList();
                model.Vacancies = context.vacancies.Where(x => x.name.ToLower().Contains(keyword.ToLower())).ToList();
            }
            return View(model);
        }
        public ActionResult MyFavorites()
        {
            return View();
        }
        public ActionResult ViewJobPosting(int id)
        {
            var view = new JobPostingViewModel();
            var vacancies = context.vacancies.ToList();
            view.Vacancy = context.vacancies.Where(x => x.id == id).FirstOrDefault();
            //view.dateOfPublishing = '14/12/2017';
            return View(view);
        }

        public ActionResult ResumePostings()
        {
            var userId = User.Identity.GetUserId();
            var model = new ViewResumesViewModel();
            model.Resumes = context.position_resumes.Where(x => x.student_id == userId).ToList();
            return View(model);
        }
        public ActionResult ViewProfile()
        {
            var model = new StudentProfileViewModel();
            var userId = User.Identity.GetUserId();
            model.Profile = context.student_profiles.Where(x => x.student_id == userId).FirstOrDefault() ?? new student_profiles();

            return View(model);
        }
        public ActionResult Competence()
        {
            return View();
        }

        
        [Authorize(Roles = "Student")]
        public ActionResult AddOrEditResume(int? id)
        {
            var model = new ViewResumeViewModel();
            var userId = User.Identity.GetUserId();
            model.Profile = context.position_resumes.Where(x => x.id == id).FirstOrDefault() ?? new position_resumes();
            model.job_type = context.job_types.ToList();
            model.experience_levels = context.experience_levels.OrderBy(x => x.id).ToList();
            model.education_levels = context.education_levels.ToList();
            return View(model);
        }

        [HttpPost]
        public ActionResult AddOrEditResume(EditResumeViewModel model)
        {
            var job_type = context.job_types.ToList();
            var experience_levels = context.experience_levels.OrderBy(x => x.id).ToList();
            var education_levels = context.education_levels.ToList();
            if (model.id == 0)
            {
                var profile = new position_resumes();
                profile.student_id = User.Identity.GetUserId();
                profile.name = model.name;
                profile.is_relocate = model.is_relocate;
                profile.city = model.city;
                profile.country = model.country;
                profile.description = model.description;
                profile.education_level = education_levels.Where(x=>x.id == model.education_level).FirstOrDefault();
                profile.experience_level = experience_levels.Where(x => x.id == model.experience_level).FirstOrDefault();
                profile.job_type = job_type.Where(x => x.id == model.job_type).FirstOrDefault();
                context.position_resumes.Add(profile);
                context.SaveChanges();
            }
            if(model.id != 0)
            {
                var profile = context.position_resumes.Where(x => x.id == model.id).FirstOrDefault();
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
            return RedirectToAction("ResumePostings");
        }

    }
}