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

        public virtual DbSet<aspnet_Applications> aspnet_Applications { get; set; }
        public virtual DbSet<aspnet_Membership> aspnet_Membership { get; set; }
        public virtual DbSet<aspnet_Paths> aspnet_Paths { get; set; }
        public virtual DbSet<aspnet_PersonalizationAllUsers> aspnet_PersonalizationAllUsers { get; set; }
        public virtual DbSet<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUser { get; set; }
        public virtual DbSet<aspnet_Profile> aspnet_Profile { get; set; }
        public virtual DbSet<aspnet_Roles> aspnet_Roles { get; set; }
        public virtual DbSet<aspnet_SchemaVersions> aspnet_SchemaVersions { get; set; }
        public virtual DbSet<aspnet_Users> aspnet_Users { get; set; }
        public virtual DbSet<aspnet_WebEvent_Events> aspnet_WebEvent_Events { get; set; }
        public virtual DbSet<JobsDb_Companies> JobsDb_Companies { get; set; }
        public virtual DbSet<JobsDb_EducationLevels> JobsDb_EducationLevels { get; set; }
        public virtual DbSet<JobsDb_ExperienceLevels> JobsDb_ExperienceLevels { get; set; }
        public virtual DbSet<JobsDb_JobPostings> JobsDb_JobPostings { get; set; }
        public virtual DbSet<JobsDb_JobTypes> JobsDb_JobTypes { get; set; }
        public virtual DbSet<JobsDb_MyJobs> JobsDb_MyJobs { get; set; }
        public virtual DbSet<JobsDb_MyResumes> JobsDb_MyResumes { get; set; }
        public virtual DbSet<JobsDb_MySearches> JobsDb_MySearches { get; set; }
        public virtual DbSet<JobsDb_Resumes> JobsDb_Resumes { get; set; }
        public virtual DbSet<JobsDb_States> JobsDb_States { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<JobsDb_Countries> JobsDb_Countries { get; set; }
        public virtual DbSet<vw_aspnet_Applications> vw_aspnet_Applications { get; set; }
        public virtual DbSet<vw_aspnet_MembershipUsers> vw_aspnet_MembershipUsers { get; set; }
        public virtual DbSet<vw_aspnet_Profiles> vw_aspnet_Profiles { get; set; }
        public virtual DbSet<vw_aspnet_Roles> vw_aspnet_Roles { get; set; }
        public virtual DbSet<vw_aspnet_Users> vw_aspnet_Users { get; set; }
        public virtual DbSet<vw_aspnet_UsersInRoles> vw_aspnet_UsersInRoles { get; set; }
        public virtual DbSet<vw_aspnet_WebPartState_Paths> vw_aspnet_WebPartState_Paths { get; set; }
        public virtual DbSet<vw_aspnet_WebPartState_Shared> vw_aspnet_WebPartState_Shared { get; set; }
        public virtual DbSet<vw_aspnet_WebPartState_User> vw_aspnet_WebPartState_User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<aspnet_Applications>()
                .HasMany(e => e.aspnet_Membership)
                .WithRequired(e => e.aspnet_Applications)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Applications>()
                .HasMany(e => e.aspnet_Paths)
                .WithRequired(e => e.aspnet_Applications)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Applications>()
                .HasMany(e => e.aspnet_Roles)
                .WithRequired(e => e.aspnet_Applications)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Applications>()
                .HasMany(e => e.aspnet_Users)
                .WithRequired(e => e.aspnet_Applications)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Paths>()
                .HasOptional(e => e.aspnet_PersonalizationAllUsers)
                .WithRequired(e => e.aspnet_Paths);

            modelBuilder.Entity<aspnet_Roles>()
                .HasMany(e => e.aspnet_Users)
                .WithMany(e => e.aspnet_Roles)
                .Map(m => m.ToTable("aspnet_UsersInRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<aspnet_Users>()
                .HasOptional(e => e.aspnet_Membership)
                .WithRequired(e => e.aspnet_Users);

            modelBuilder.Entity<aspnet_Users>()
                .HasOptional(e => e.aspnet_Profile)
                .WithRequired(e => e.aspnet_Users);

            modelBuilder.Entity<aspnet_WebEvent_Events>()
                .Property(e => e.EventId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<aspnet_WebEvent_Events>()
                .Property(e => e.EventSequence)
                .HasPrecision(19, 0);

            modelBuilder.Entity<aspnet_WebEvent_Events>()
                .Property(e => e.EventOccurrence)
                .HasPrecision(19, 0);

            modelBuilder.Entity<JobsDb_Companies>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<JobsDb_Companies>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<JobsDb_Companies>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<JobsDb_Companies>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<JobsDb_Companies>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<JobsDb_Companies>()
                .Property(e => e.Zip)
                .IsUnicode(false);

            modelBuilder.Entity<JobsDb_Companies>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<JobsDb_Companies>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<JobsDb_Companies>()
                .Property(e => e.CompanyEmail)
                .IsUnicode(false);

            modelBuilder.Entity<JobsDb_Companies>()
                .Property(e => e.WebSiteUrl)
                .IsUnicode(false);

            modelBuilder.Entity<JobsDb_Companies>()
                .Property(e => e.CompanyProfile)
                .IsUnicode(false);

            modelBuilder.Entity<JobsDb_EducationLevels>()
                .Property(e => e.EducationLevelName)
                .IsUnicode(false);

            modelBuilder.Entity<JobsDb_ExperienceLevels>()
                .Property(e => e.ExperienceLevelName)
                .IsUnicode(false);

            modelBuilder.Entity<JobsDb_JobPostings>()
                .Property(e => e.ContactPerson)
                .IsUnicode(false);

            modelBuilder.Entity<JobsDb_JobPostings>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<JobsDb_JobPostings>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<JobsDb_JobPostings>()
                .Property(e => e.JobCode)
                .IsUnicode(false);

            modelBuilder.Entity<JobsDb_JobPostings>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<JobsDb_JobPostings>()
                .Property(e => e.MinSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<JobsDb_JobPostings>()
                .Property(e => e.MaxSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<JobsDb_JobPostings>()
                .Property(e => e.JobDescription)
                .IsUnicode(false);

            modelBuilder.Entity<JobsDb_JobPostings>()
                .Property(e => e.PostedBy)
                .IsUnicode(false);

            modelBuilder.Entity<JobsDb_JobTypes>()
                .Property(e => e.JobTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<JobsDb_MyJobs>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<JobsDb_MyResumes>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<JobsDb_MySearches>()
                .Property(e => e.SearchCriteria)
                .IsUnicode(false);

            modelBuilder.Entity<JobsDb_MySearches>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<JobsDb_MySearches>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<JobsDb_Resumes>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<JobsDb_Resumes>()
                .Property(e => e.JobTitle)
                .IsUnicode(false);

            modelBuilder.Entity<JobsDb_Resumes>()
                .Property(e => e.TargetCity)
                .IsUnicode(false);

            modelBuilder.Entity<JobsDb_Resumes>()
                .Property(e => e.ResumeText)
                .IsUnicode(false);

            modelBuilder.Entity<JobsDb_Resumes>()
                .Property(e => e.CoverLetterText)
                .IsUnicode(false);

            modelBuilder.Entity<JobsDb_States>()
                .Property(e => e.StateName)
                .IsUnicode(false);

            modelBuilder.Entity<JobsDb_Countries>()
                .Property(e => e.CountryName)
                .IsUnicode(false);
        }
    }
}
