namespace KhaiJobs.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JobsDb_ExperienceLevels
    {
        [Key]
        public int ExperienceLevelID { get; set; }

        [StringLength(255)]
        public string ExperienceLevelName { get; set; }
    }
}
