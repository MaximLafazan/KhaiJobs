namespace KhaiJobs.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("public.knowleges")]
    public partial class knowlege
    {
        public int id { get; set; }

        public int? id_knowleges_categories { get; set; }

        public virtual knowleges_categories knowleges_categories { get; set; }
        public string name { get; set; }
    }
}
