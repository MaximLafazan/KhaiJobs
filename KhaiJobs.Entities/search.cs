namespace KhaiJobs.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("public.searches")]
    public partial class search
    {
        public int id { get; set; }
        public string search_query { get; set; }
        public virtual company company { get; set; }
        public virtual student_profiles student_profiles  { get; set; }

    }
}
