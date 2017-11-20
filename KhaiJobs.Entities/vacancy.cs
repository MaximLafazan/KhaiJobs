namespace KhaiJobs.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.vacancies")]
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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vacancies_personal_competences> vacancies_personal_competences { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vacancies_proffessional_competences> vacancies_proffessional_competences { get; set; }
    }
}
