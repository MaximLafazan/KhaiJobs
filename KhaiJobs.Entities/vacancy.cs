namespace KhaiJobs.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("vacancies")]
    public partial class vacancy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public vacancy()
        {
            vacancies_personal_competences = new HashSet<vacancies_personal_competences>();
            vacancies_proffessional_competences = new HashSet<vacancies_proffessional_competences>();
        }

        public int id { get; set; }
        public int? id_positions { get; set; }
        public virtual position position { get; set; }
        public education_levels education_level { get; set; }
        public experience_levels experience_level { get; set; }
        public job_types job_type { get; set; }
        public string description { get; set; }
        public string contact { get; set; }
        public virtual company company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vacancies_personal_competences> vacancies_personal_competences { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vacancies_proffessional_competences> vacancies_proffessional_competences { get; set; }
        public string name { get; set; }

    }
}
