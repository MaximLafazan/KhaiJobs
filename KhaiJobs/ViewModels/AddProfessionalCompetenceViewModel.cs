using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KhaiJobs.ViewModels
{
    public class AddProfessionalCompetenceViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProfileId { get; set; }
        public List<string> Skills { get; set; }
        public List<string> Knowlege { get; set; }
        public List<string> Abilities { get; set; }
    }
}