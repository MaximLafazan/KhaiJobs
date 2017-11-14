namespace KhaiJobs.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JobsDb_EducationLevels
    {
        [Key]
        public int EducationLevelID { get; set; }

        [StringLength(50)]
        public string EducationLevelName { get; set; }
    }
}
