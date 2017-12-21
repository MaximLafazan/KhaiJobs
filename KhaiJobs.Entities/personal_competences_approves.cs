namespace KhaiJobs.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("personal_competences_approves")]
    public partial class personal_competences_approves
    {
        public int id { get; set; }

        public int? id_tutors { get; set; }

        public int? id_students_personal_competences { get; set; }

        public virtual students_personal_competences students_personal_competences { get; set; }

        public virtual tutor tutor { get; set; }
        public DateTime ApproveDate { get; set; }
    }
}
