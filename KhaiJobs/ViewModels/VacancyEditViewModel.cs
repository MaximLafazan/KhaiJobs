using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KhaiJobs.ViewModels
{
    public class VacancyEditViewModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public int job_type { get; set; }
        public int education_level { get; set; }
        public int experience_level { get; set; }
        public string description { get; set; }
        public string contact { get; set; }

    }
}