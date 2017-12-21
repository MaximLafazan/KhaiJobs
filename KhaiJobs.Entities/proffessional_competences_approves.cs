namespace KhaiJobs.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("proffessional_competences_approves")]
    public partial class proffessional_competences_approves
    {
        public int id { get; set; }

        public int? id_tutors { get; set; }

        public int? id_students_proffessional_competences { get; set; }

        public virtual students_proffessional_competences students_proffessional_competences { get; set; }

        public virtual tutor tutor { get; set; }
        public DateTime ApproveDate { get; set; }
    }
}
