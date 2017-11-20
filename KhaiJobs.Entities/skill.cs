namespace KhaiJobs.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.skills")]
    public partial class skill
    {
        public int id { get; set; }

        public int? id_skills_categories { get; set; }

        public virtual skills_categories skills_categories { get; set; }
    }
}
