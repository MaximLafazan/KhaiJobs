using KhaiJobs.DataAccess;
using KhaiJobs.Entities;
using KhaiJobs.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KhaiJobs.Services
{
    public class CompanyService
    {
        MainContext _context = new MainContext();
        public CompanyService()
        {
        }

        public ViewResumeViewModel GetViewResume(int id)
        {
            var viewResumeViewModel = new ViewResumeViewModel();
            var resume = _context.position_resumes.Where(x => x.id == id).FirstOrDefault() ?? new position_resumes();
            if (resume == null)
            {
                return null;
            }
            viewResumeViewModel.id = resume.id;
            viewResumeViewModel.id_positions = resume.id_positions;
            viewResumeViewModel.id_student_profiles = resume.id_student_profiles;

            viewResumeViewModel.city = resume.city;
            viewResumeViewModel.country = resume.country;
            viewResumeViewModel.creation_date = resume.creation_date.ToLongDateString();
            //viewResumeViewModel.description = resume.description;

            viewResumeViewModel.education_level = (resume.education_level == null) ? "Не указан" : resume.education_level.name;
            viewResumeViewModel.experience_level = (resume.experience_level == null) ? "Не указан" : resume.experience_level.name;

            viewResumeViewModel.is_relocate = resume.is_relocate ? "Да" : "Нет";
            viewResumeViewModel.job_type = (resume.job_type == null)? "Не указан" : resume.job_type.name;

            viewResumeViewModel.name = resume.name;

            if (resume.student_profiles != null) {

                viewResumeViewModel.StudentProfile.id = resume.student_profiles.id;
                viewResumeViewModel.StudentProfile.FullName = resume.student_profiles.name + " " + resume.student_profiles.lastname;
                viewResumeViewModel.StudentProfile.Phone = string.IsNullOrEmpty(resume.student_profiles.phone)?"Не указан" : resume.student_profiles.phone;
            }
            if (resume.student_profiles == null)
            {
                viewResumeViewModel.StudentProfile.id = 0;
                viewResumeViewModel.StudentProfile.FullName = "Не указан";
                viewResumeViewModel.StudentProfile.Phone = "Не указан";
            }

            return viewResumeViewModel;
        }
    }
}