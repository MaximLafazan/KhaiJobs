namespace KhaiJobs.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("education_levels")]
    public partial class education_levels
    {
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }
    }
}
