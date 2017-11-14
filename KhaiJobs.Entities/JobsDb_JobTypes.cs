namespace KhaiJobs.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JobsDb_JobTypes
    {
        [Key]
        public int JobTypeID { get; set; }

        [StringLength(50)]
        public string JobTypeName { get; set; }
    }
}
