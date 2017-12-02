namespace KhaiJobs.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.student_profiles")]
    public partial class student_profiles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public student_profiles()
        {
            position_resumes = new HashSet<position_resumes>();
            students_personal_competences = new HashSet<students_personal_competences>();
            students_proffessional_competences = new HashSet<students_proffessional_competences>();
        }

        public int id { get; set; }
        public string name { get; set; }
        public job_types job_type { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public bool is_relocate { get; set; }
        public education_levels education_level { get; set; }
        public experience_levels experience_level { get; set; }
        public string description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<position_resumes> position_resumes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<students_personal_competences> students_personal_competences { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<students_proffessional_competences> students_proffessional_competences { get; set; }
    }
}
