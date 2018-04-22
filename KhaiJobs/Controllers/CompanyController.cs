using KhaiJobs.DataAccess;
using KhaiJobs.Entities;
using KhaiJobs.Services;
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
        MainContext _context;
        CompanyService _companyService;
        public CompanyController()
        {
            _context = new MainContext();
            _companyService = new CompanyService();
        }
        public ActionResult AddEditPosting(int id = 0)
        {
            var model = new VacancyViewModel();
            model.Vacancy = _context.vacancies.Where(x => x.id == id).FirstOrDefault() ?? new vacancy();
            model.job_type = _context.job_types.ToList();
            model.experience_levels = _context.experience_levels.OrderBy(x => x.id).ToList();
            model.education_levels = _context.education_levels.ToList();

            return View(model);
        }

        [HttpPost]
        public ActionResult AddEditPosting(VacancyEditViewModel model)
        {
            var job_type = _context.job_types.ToList();
            var experience_levels = _context.experience_levels.OrderBy(x => x.id).ToList();
            var education_levels = _context.education_levels.ToList();
            var userId = User.Identity.GetUserId();
            if (model.id == 0)
            {
                var vacancy = new vacancy();
                vacancy.name = model.name;
                vacancy.description = model.description;
                vacancy.contact = model.contact;
                vacancy.education_level = education_levels.Where(x => x.id == model.education_level).FirstOrDefault();
                vacancy.experience_level = experience_levels.Where(x => x.id == model.experience_level).FirstOrDefault();
                vacancy.job_type = job_type.Where(x => x.id == model.job_type).FirstOrDefault();
                vacancy.company = _context.companies.FirstOrDefault(x => x.company_id == userId);
                _context.vacancies.Add(vacancy);
                _context.SaveChanges();
            }
            if (model.id != 0)
            {
                var vacancy = _context.vacancies.Where(x => x.id == model.id).FirstOrDefault();
                vacancy.name = model.name;
                vacancy.description = model.description;
                vacancy.contact = model.contact;
                vacancy.education_level = education_levels.Where(x => x.id == model.education_level).FirstOrDefault();
                vacancy.experience_level = experience_levels.Where(x => x.id == model.experience_level).FirstOrDefault();
                vacancy.job_type = job_type.Where(x => x.id == model.job_type).FirstOrDefault();
                _context.SaveChanges();
            }
            return RedirectToAction("JobsPostings");
        }
        [Authorize(Roles = "Company")]
        public ActionResult CompanyProfile()
        {
            var model = new company();
            var userId = User.Identity.GetUserId();
            model = _context.companies.Where(x => x.company_id == userId).FirstOrDefault() ?? new company();
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
                _context.companies.Add(company);
                _context.SaveChanges();
            }
            if (model.id != 0)
            {
                var company = _context.companies.Where(x => x.id == model.id).FirstOrDefault();
                company.name = model.name;
                company.phone = model.phone;
                company.website_url = model.website_url;
                company.city = model.city;
                company.country = model.country;
                company.description = model.description;
                company.address = model.address;
                company.email = model.email;
                _context.SaveChanges();
            }
            return RedirectToAction("CompanyProfile");
        }

        public ActionResult JobPostings()
        {
            var userId = User.Identity.GetUserId();
            var model = new VacanciesViewModel();
            model.Vacancies = _context.vacancies.Where(x => x.company.company_id == userId).ToList();
            return View(model);
        }

        public ActionResult MyFavorites()
        {
            return View();
        }

        public ActionResult ResumeSearch(string keyword)
        {
            var model = new ResumeSearchViewModel();
            model.Resumes = new List<position_resumes>();
            if (!string.IsNullOrEmpty(keyword))
            {
                model.Resumes = _context.position_resumes.Where(x => x.name.ToLower().Contains(keyword.ToLower())).ToList();
            }
            return View(model);
        }

        public ActionResult ViewResume(int id = 0)
        {
            var viewResumeViewModel = _companyService.GetViewResume(id);
            return View(viewResumeViewModel);
        }


    }
}