namespace KhaiJobs.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("companies")]
    public partial class company
    {
        public int id { get; set; }

        [StringLength(255)]
        public string name { get; set; }

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
        public string email { get; set; }

        [StringLength(255)]
        public string website_url { get; set; }

        public string description { get; set; }

        public string company_id { get; set; }
    }
}
