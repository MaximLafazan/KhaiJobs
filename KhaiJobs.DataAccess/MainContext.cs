namespace KhaiJobs.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Entities;

    public partial class MainContext : DbContext
    {
        public MainContext()
            : base("name=MainContext1")
        {
        }

        public virtual DbSet<ability> abilities { get; set; }
        public virtual DbSet<company> companies { get; set; }
        public virtual DbSet<discipline> disciplines { get; set; }
        public virtual DbSet<domain> domains { get; set; }
        public virtual DbSet<education_levels> education_levels { get; set; }
        public virtual DbSet<experience_levels> experience_levels { get; set; }
        public virtual DbSet<job_types> job_types { get; set; }
        public virtual DbSet<knowlege> knowleges { get; set; }
        public virtual DbSet<knowleges_categories> knowleges_categories { get; set; }
        public virtual DbSet<personal_competences> personal_competences { get; set; }
        public virtual DbSet<personal_competences_approves> personal_competences_approves { get; set; }
        public virtual DbSet<personal_competences_levels> personal_competences_levels { get; set; }
        public virtual DbSet<position_resumes> position_resumes { get; set; }
        public virtual DbSet<position> positions { get; set; }
        public virtual DbSet<proffessional_competences> proffessional_competences { get; set; }
        public virtual DbSet<proffessional_competences_approves> proffessional_competences_approves { get; set; }
        public virtual DbSet<proffessional_competences_levels> proffessional_competences_levels { get; set; }
        public virtual DbSet<search> searches { get; set; }
        public virtual DbSet<skill> skills { get; set; }
        public virtual DbSet<skills_categories> skills_categories { get; set; }
        public virtual DbSet<student_profiles> student_profiles { get; set; }
        public virtual DbSet<students_personal_competences> students_personal_competences { get; set; }
        public virtual DbSet<students_proffessional_competences> students_proffessional_competences { get; set; }
        public virtual DbSet<tutor> tutors { get; set; }
        public virtual DbSet<vacancy> vacancies { get; set; }
        public virtual DbSet<vacancies_personal_competences> vacancies_personal_competences { get; set; }
        public virtual DbSet<vacancies_proffessional_competences> vacancies_proffessional_competences { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<domain>()
                .HasMany(e => e.proffessional_competences)
                .WithOptional(e => e.domain)
                .HasForeignKey(e => e.id_domain);

            modelBuilder.Entity<knowleges_categories>()
                .HasMany(e => e.knowleges)
                .WithOptional(e => e.knowleges_categories)
                .HasForeignKey(e => e.id_knowleges_categories);

            modelBuilder.Entity<personal_competences>()
                .HasMany(e => e.vacancies_personal_competences)
                .WithOptional(e => e.personal_competences)
                .HasForeignKey(e => e.id_personal_competences);

            modelBuilder.Entity<personal_competences_levels>()
                .HasMany(e => e.students_personal_competences)
                .WithOptional(e => e.personal_competences_levels)
                .HasForeignKey(e => e.id_personal_competences_levels);

            modelBuilder.Entity<personal_competences_levels>()
                .HasMany(e => e.vacancies_personal_competences)
                .WithOptional(e => e.personal_competences_levels)
                .HasForeignKey(e => e.id_personal_competences_levels);

            modelBuilder.Entity<position>()
                .HasMany(e => e.position_resumes)
                .WithOptional(e => e.position)
                .HasForeignKey(e => e.id_positions);

            modelBuilder.Entity<position>()
                .HasMany(e => e.vacancies)
                .WithOptional(e => e.position)
                .HasForeignKey(e => e.id_positions);

            modelBuilder.Entity<proffessional_competences>()
                .HasMany(e => e.vacancies_proffessional_competences)
                .WithOptional(e => e.proffessional_competences)
                .HasForeignKey(e => e.id_proffessional_competences);

            modelBuilder.Entity<proffessional_competences_levels>()
                .HasMany(e => e.students_proffessional_competences)
                .WithOptional(e => e.proffessional_competences_levels)
                .HasForeignKey(e => e.id_proffessional_competences_levels);

            modelBuilder.Entity<proffessional_competences_levels>()
                .HasMany(e => e.vacancies_proffessional_competences)
                .WithOptional(e => e.proffessional_competences_levels)
                .HasForeignKey(e => e.id_proffessional_competences_levels);

            modelBuilder.Entity<skills_categories>()
                .HasMany(e => e.skills)
                .WithOptional(e => e.skills_categories)
                .HasForeignKey(e => e.id_skills_categories);

            modelBuilder.Entity<student_profiles>()
                .HasMany(e => e.position_resumes)
                .WithOptional(e => e.student_profiles)
                .HasForeignKey(e => e.id_student_profiles);

            modelBuilder.Entity<student_profiles>()
                .HasMany(e => e.students_personal_competences)
                .WithOptional(e => e.student_profiles)
                .HasForeignKey(e => e.id_student_profiles);

            modelBuilder.Entity<student_profiles>()
                .HasMany(e => e.students_proffessional_competences)
                .WithOptional(e => e.student_profiles)
                .HasForeignKey(e => e.id_student_profiles);

            modelBuilder.Entity<students_personal_competences>()
                .HasMany(e => e.personal_competences_approves)
                .WithOptional(e => e.students_personal_competences)
                .HasForeignKey(e => e.id_students_personal_competences);

            modelBuilder.Entity<students_proffessional_competences>()
                .HasMany(e => e.proffessional_competences_approves)
                .WithOptional(e => e.students_proffessional_competences)
                .HasForeignKey(e => e.id_students_proffessional_competences);

            modelBuilder.Entity<tutor>()
                .HasMany(e => e.personal_competences_approves)
                .WithOptional(e => e.tutor)
                .HasForeignKey(e => e.id_tutors);

            modelBuilder.Entity<tutor>()
                .HasMany(e => e.proffessional_competences_approves)
                .WithOptional(e => e.tutor)
                .HasForeignKey(e => e.id_tutors);

            modelBuilder.Entity<vacancy>()
                .HasMany(e => e.vacancies_personal_competences)
                .WithOptional(e => e.vacancy)
                .HasForeignKey(e => e.id_vacancies);

            modelBuilder.Entity<vacancy>()
                .HasMany(e => e.vacancies_proffessional_competences)
                .WithOptional(e => e.vacancy)
                .HasForeignKey(e => e.id_vacancies);
        }
    }
}
