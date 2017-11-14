namespace KhaiJobs.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JobsDb_MySearches
    {
        [Key]
        public int MySearchID { get; set; }

        [StringLength(255)]
        public string SearchCriteria { get; set; }

        public int? CountryID { get; set; }

        public int? StateID { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        public DateTime? PostDate { get; set; }
    }
}
