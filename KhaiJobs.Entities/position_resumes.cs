namespace KhaiJobs.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.position_resumes")]
    public partial class position_resumes
    {
        public int id { get; set; }

        public int? id_positions { get; set; }

        public int? id_student_profiles { get; set; }

        public virtual position position { get; set; }

        public virtual student_profiles student_profiles { get; set; }
    }
}