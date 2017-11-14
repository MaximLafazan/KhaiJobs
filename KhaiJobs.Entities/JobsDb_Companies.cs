namespace KhaiJobs.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JobsDb_Companies
    {
        [Key]
        public int CompanyID { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(255)]
        public string CompanyName { get; set; }

        [StringLength(255)]
        public string Address1 { get; set; }

        [StringLength(255)]
        public string Address2 { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        public int? StateID { get; set; }

        public int? CountryID { get; set; }

        [StringLength(50)]
        public string Zip { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(255)]
        public string CompanyEmail { get; set; }

        [StringLength(255)]
        public string WebSiteUrl { get; set; }

        [Column(TypeName = "text")]
        public string CompanyProfile { get; set; }
    }
}
