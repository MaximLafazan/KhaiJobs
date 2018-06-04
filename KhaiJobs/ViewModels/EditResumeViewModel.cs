using KhaiJobs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KhaiJobs.ViewModels
{
    public class EditResumeViewModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public int job_type { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public bool is_relocate { get; set; }
        public int education_level { get; set; }
        public int experience_level { get; set; }
        public string description { get; set; }
        public string student_id { get; set; }
        public DateTime creation_date { get; set; }
    }
}