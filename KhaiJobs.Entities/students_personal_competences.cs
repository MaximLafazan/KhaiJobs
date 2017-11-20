namespace KhaiJobs.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.students_personal_competences")]
    public partial class students_personal_competences
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public students_personal_competences()
        {
            personal_competences_approves = new HashSet<personal_competences_approves>();
        }

        public int id { get; set; }

        public int? id_student_profiles { get; set; }

        public int? id_personal_competences_levels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<personal_competences_approves> personal_competences_approves { get; set; }

        public virtual personal_competences_levels personal_competences_levels { get; set; }

        public virtual student_profiles student_profiles { get; set; }
    }
}
