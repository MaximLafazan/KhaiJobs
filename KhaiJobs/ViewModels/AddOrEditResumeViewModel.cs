using KhaiJobs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KhaiJobs.ViewModels
{
    public class AddOrEditResumeViewModel
    {
        public position_resumes Profile { get; set; }
        public List<job_types> job_type { get; set; }
        public List<education_levels> education_levels { get; set; }
        public List<experience_levels> experience_levels { get; set; }
    }
}