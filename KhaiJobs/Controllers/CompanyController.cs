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
    public class CompanyController : Controller
    {
        MainContext context = new MainContext();

        public ActionResult AddEditPosting(int id = 0)
        {
            var model = new VacancyViewModel();
            model.Vacancy = context.vacancies.Where(x => x.id == id).FirstOrDefault() ?? new vacancy();
            model.job_type = context.job_types.ToList();
            model.experience_levels = context.experience_levels.OrderBy(x => x.id).ToList();
            model.education_levels = context.education_levels.ToList();

            return View(model);
        }

        [HttpPost]
        public ActionResult AddEditPosting(VacancyEditViewModel model)
        {
            var job_type = context.job_types.ToList();
            var experience_levels = context.experience_levels.OrderBy(x => x.id).ToList();
            var education_levels = context.education_levels.ToList();
            if (model.id == 0)
            {
                var vacancy = new vacancy();
                vacancy.name = model.name;
                vacancy.description = model.description;
                vacancy.contact = model.contact;
                vacancy.education_level = education_levels.Where(x => x.id == model.education_level).FirstOrDefault();
                vacancy.experience_level = experience_levels.Where(x => x.id == model.experience_level).FirstOrDefault();
                vacancy.job_type = job_type.Where(x => x.id == model.job_type).FirstOrDefault();
                context.vacancies.Add(vacancy);
                context.SaveChanges();
            }
            if (model.id != 0)
            {
                var vacancy = context.vacancies.Where(x => x.id == model.id).FirstOrDefault();
                vacancy.name = model.name;
                vacancy.description = model.description;
                vacancy.contact = model.contact;
                vacancy.education_level = education_levels.Where(x => x.id == model.education_level).FirstOrDefault();
                vacancy.experience_level = experience_levels.Where(x => x.id == model.experience_level).FirstOrDefault();
                vacancy.job_type = job_type.Where(x => x.id == model.job_type).FirstOrDefault();
                context.SaveChanges();
            }
            return RedirectToAction("StudentProfile");
        }
        [Authorize(Roles = "Company")]
        public ActionResult CompanyProfile()
        {
            var model = new company();
            var userId = User.Identity.GetUserId();
            model = context.companies.Where(x => x.company_id == userId).FirstOrDefault() ?? new company();
            return View(model);
        }

        [HttpPost]
        public ActionResult CompanyProfile(company model)
        {
            var userId = User.Identity.GetUserId();
            if (model.id == 0)
            {
                var company = model;
                company.company_id = userId;
                context.companies.Add(company);
                context.SaveChanges();
            }
            if (model.id != 0)
            {
                var company = context.companies.Where(x => x.id == model.id).FirstOrDefault();
                company.name = model.name;
                company.phone = model.phone;
                company.website_url = model.website_url;
                company.city = model.city;
                company.country = model.country;
                company.description = model.description;
                company.address = model.address;
                company.email = model.email;
                context.SaveChanges();
            }
            return RedirectToAction("CompanyProfile");
        }

        public ActionResult JobPostings()
        {
            return View();
        }

        public ActionResult MyFavorites()
        {
            return View();
        }

        public ActionResult ResumeSearch(string keyword)
        {
            var model = new ResumeSearchViewModel();
            model.Resumes = new List<student_profiles>();
            if (!string.IsNullOrEmpty(keyword))
            {
                model.Resumes = context.student_profiles.Where(x => x.name.ToLower().Contains(keyword.ToLower())).ToList();
            }
            return View(model);
        }

        public ActionResult ViewResume()
        {
            return View();
        }


    }
}