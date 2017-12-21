namespace KhaiJobs.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("abilities")]
    public partial class ability
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
