namespace KhaiJobs.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.students_proffessional_competences")]
    public partial class students_proffessional_competences
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public students_proffessional_competences()
        {
            proffessional_competences_approves = new HashSet<proffessional_competences_approves>();
        }

        public int id { get; set; }

        public int? id_student_profiles { get; set; }

        public int? id_proffessional_competences_levels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<proffessional_competences_approves> proffessional_competences_approves { get; set; }

        public virtual proffessional_competences_levels proffessional_competences_levels { get; set; }

        public virtual student_profiles student_profiles { get; set; }
    }
}
