namespace KhaiJobs.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_aspnet_Applications
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(256)]
        public string ApplicationName { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ApplicationId { get; set; }

        [StringLength(256)]
        public string Description { get; set; }
    }
}
