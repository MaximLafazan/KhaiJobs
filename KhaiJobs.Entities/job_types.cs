namespace KhaiJobs.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("public.job_types")]
    public partial class job_types
    {
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }
    }
}
