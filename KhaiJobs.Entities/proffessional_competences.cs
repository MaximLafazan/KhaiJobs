namespace KhaiJobs.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("proffessional_competences")]
    public partial class proffessional_competences
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public proffessional_competences()
        {
            vacancies_proffessional_competences = new HashSet<vacancies_proffessional_competences>();
        }

        public int id { get; set; }

        public int? id_domain { get; set; }

        public virtual domain domain { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vacancies_proffessional_competences> vacancies_proffessional_competences { get; set; }
        public string name { get; set; }

        public virtual List<skill> skills { get; set; }
        public virtual List<knowlege> knowlege { get; set; }
        public virtual List<ability> abilities { get; set; }
    }
}
