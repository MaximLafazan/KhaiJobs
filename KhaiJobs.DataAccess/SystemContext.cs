namespace KhaiJobs.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Entities;

    public partial class SystemContext : DbContext
    {
        public SystemContext()
            : base("name=SystemContext")
        {
        }

        //public virtual DbSet<JobsDb_Companies> JobsDb_Companies { get; set; }
        //public virtual DbSet<JobsDb_EducationLevels> JobsDb_EducationLevels { get; set; }
        //public virtual DbSet<JobsDb_ExperienceLevels> JobsDb_ExperienceLevels { get; set; }
        //public virtual DbSet<JobsDb_JobPostings> JobsDb_JobPostings { get; set; }
        //public virtual DbSet<JobsDb_JobTypes> JobsDb_JobTypes { get; set; }
        //public virtual DbSet<JobsDb_MyJobs> JobsDb_MyJobs { get; set; }
        //public virtual DbSet<JobsDb_MyResumes> JobsDb_MyResumes { get; set; }
        //public virtual DbSet<JobsDb_MySearches> JobsDb_MySearches { get; set; }
        //public virtual DbSet<JobsDb_Resumes> JobsDb_Resumes { get; set; }
        //public virtual DbSet<JobsDb_States> JobsDb_States { get; set; }
        //public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        //public virtual DbSet<JobsDb_Countries> JobsDb_Countries { get; set; }

    }
}
