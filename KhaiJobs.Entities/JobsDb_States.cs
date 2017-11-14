namespace KhaiJobs.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JobsDb_States
    {
        [Key]
        public int StateID { get; set; }

        public int CountryID { get; set; }

        [StringLength(255)]
        public string StateName { get; set; }
    }
}
