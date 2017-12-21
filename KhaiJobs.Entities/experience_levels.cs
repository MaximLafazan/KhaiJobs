namespace KhaiJobs.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("experience_levels")]
    public partial class experience_levels
    {
        public int id { get; set; }

        [StringLength(255)]
        public string name { get; set; }
    }
}
