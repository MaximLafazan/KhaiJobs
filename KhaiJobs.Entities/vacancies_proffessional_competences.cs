namespace KhaiJobs.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.vacancies_proffessional_competences")]
    public partial class vacancies_proffessional_competences
    {
        public int id { get; set; }

        public int? id_vacancies { get; set; }

        public int? id_proffessional_competences { get; set; }

        public int? id_proffessional_competences_levels { get; set; }

        public virtual proffessional_competences proffessional_competences { get; set; }

        public virtual proffessional_competences_levels proffessional_competences_levels { get; set; }

        public virtual vacancy vacancy { get; set; }
    }
}
