namespace KhaiJobs.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("proffessional_competences_levels")]
    public partial class proffessional_competences_levels
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public proffessional_competences_levels()
        {
            students_proffessional_competences = new HashSet<students_proffessional_competences>();
            vacancies_proffessional_competences = new HashSet<vacancies_proffessional_competences>();
        }

        public int id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<students_proffessional_competences> students_proffessional_competences { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vacancies_proffessional_competences> vacancies_proffessional_competences { get; set; }
        public int level { get; set; }
        public string name { get; set; }
    }
}
