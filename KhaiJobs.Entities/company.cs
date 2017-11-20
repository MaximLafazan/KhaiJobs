namespace KhaiJobs.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.companies")]
    public partial class company
    {
        public int id { get; set; }

        [StringLength(50)]
        public string user_name { get; set; }

        [StringLength(255)]
        public string company_name { get; set; }

        [StringLength(255)]
        public string address { get; set; }

        [StringLength(50)]
        public string city { get; set; }

        [StringLength(50)]
        public string zip { get; set; }

        [StringLength(50)]
        public string country { get; set; }

        [StringLength(50)]
        public string phone { get; set; }

        [StringLength(255)]
        public string company_email { get; set; }

        [StringLength(255)]
        public string website_url { get; set; }

        public string description { get; set; }
    }
}
