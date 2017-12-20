namespace KhaiJobs.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("public.position_resumes")]
    public partial class position_resumes
    {
        public int id { get; set; }

        public int? id_positions { get; set; }

        public int? id_student_profiles { get; set; }
        public string name { get; set; }
        public job_types job_type { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public bool is_relocate { get; set; }
        public education_levels education_level { get; set; }
        public experience_levels experience_level { get; set; }
        public string description { get; set; }
        public string student_id { get; set; }

        public virtual position position { get; set; }

        public virtual student_profiles student_profiles { get; set; }
        public virtual List<proffessional_competences> position_proffessional_competences { get; set; }
        public virtual List<personal_competences> position_personal_competences { get; set; }

    }
}
