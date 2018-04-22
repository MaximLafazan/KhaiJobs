using KhaiJobs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KhaiJobs.ViewModels
{
    public class ViewResumeViewModel
    {
        public int id { get; set; }
        public int? id_positions { get; set; }

        public int? id_student_profiles { get; set; }
        public string name { get; set; }
        public string job_type { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string is_relocate { get; set; }
        public string education_level { get; set; }
        public string experience_level { get; set; }
        public virtual StudentProfile StudentProfile { get; set; } = new StudentProfile();


        //public string description { get; set; }
        //public string student_id { get; set; }
        //public virtual position position { get; set; }
        //public virtual List<proffessional_competences> position_proffessional_competences { get; set; }
        //public virtual List<personal_competences> position_personal_competences { get; set; }
        public string creation_date { get; set; }

    }

    public class StudentProfile {
        public int id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        //public string student_id { get; set; }

    }
}