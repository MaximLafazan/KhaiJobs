namespace KhaiJobs.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("public.tutors")]
    public partial class tutor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tutor()
        {
            personal_competences_approves = new HashSet<personal_competences_approves>();
            proffessional_competences_approves = new HashSet<proffessional_competences_approves>();
        }

        public int id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<personal_competences_approves> personal_competences_approves { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<proffessional_competences_approves> proffessional_competences_approves { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string patronymic { get; set; }

        public List<discipline> disciplines { get; set; }

    }
}
