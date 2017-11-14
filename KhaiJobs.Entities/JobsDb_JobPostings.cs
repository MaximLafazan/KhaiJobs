namespace KhaiJobs.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JobsDb_JobPostings
    {
        [Key]
        public int PostingID { get; set; }

        public int? CompanyID { get; set; }

        [StringLength(255)]
        public string ContactPerson { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(50)]
        public string Department { get; set; }

        [StringLength(50)]
        public string JobCode { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        public int? StateID { get; set; }

        public int? CountryID { get; set; }

        public int? EducationLevelID { get; set; }

        public int? JobTypeID { get; set; }

        [Column(TypeName = "money")]
        public decimal? MinSalary { get; set; }

        [Column(TypeName = "money")]
        public decimal? MaxSalary { get; set; }

        [Column(TypeName = "text")]
        public string JobDescription { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PostingDate { get; set; }

        [StringLength(50)]
        public string PostedBy { get; set; }
    }
}
