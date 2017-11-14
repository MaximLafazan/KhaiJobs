namespace KhaiJobs.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JobsDb_MyResumes
    {
        [Key]
        public int MyResumeID { get; set; }

        public int? ResumeID { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}
