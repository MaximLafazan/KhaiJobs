namespace KhaiJobs.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JobsDb_Resumes
    {
        [Key]
        public int ResumeID { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(255)]
        public string JobTitle { get; set; }

        [StringLength(50)]
        public string TargetCity { get; set; }

        public int? TargetStateID { get; set; }

        public int? TargetCountryID { get; set; }

        public int? RelocationCountryID { get; set; }

        public int? TargetJobTypeID { get; set; }

        public int? EducationLevelID { get; set; }

        public int? ExperienceLevelID { get; set; }

        [Column(TypeName = "text")]
        public string ResumeText { get; set; }

        [Column(TypeName = "text")]
        public string CoverLetterText { get; set; }

        public int? CategoryID { get; set; }

        public int? SubcategoryID { get; set; }

        public DateTime? PostDate { get; set; }
    }
}
