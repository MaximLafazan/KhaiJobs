namespace KhaiJobs.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.vacancies_personal_competences")]
    public partial class vacancies_personal_competences
    {
        public int id { get; set; }

        public int? id_vacancies { get; set; }

        public int? id_personal_competences { get; set; }

        public int? id_personal_competences_levels { get; set; }

        public virtual personal_competences personal_competences { get; set; }

        public virtual personal_competences_levels personal_competences_levels { get; set; }

        public virtual vacancy vacancy { get; set; }
    }
}
