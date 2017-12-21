namespace KhaiJobs.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "public.abilities", newSchema: "dbo");
            MoveTable(name: "public.companies", newSchema: "dbo");
            MoveTable(name: "public.disciplines", newSchema: "dbo");
            MoveTable(name: "public.domain", newSchema: "dbo");
            MoveTable(name: "public.proffessional_competences", newSchema: "dbo");
            MoveTable(name: "public.vacancies_proffessional_competences", newSchema: "dbo");
            MoveTable(name: "public.proffessional_competences_levels", newSchema: "dbo");
            MoveTable(name: "public.students_proffessional_competences", newSchema: "dbo");
            MoveTable(name: "public.proffessional_competences_approves", newSchema: "dbo");
            MoveTable(name: "public.tutors", newSchema: "dbo");
            MoveTable(name: "public.personal_competences_approves", newSchema: "dbo");
            MoveTable(name: "public.students_personal_competences", newSchema: "dbo");
            MoveTable(name: "public.personal_competences_levels", newSchema: "dbo");
            MoveTable(name: "public.vacancies_personal_competences", newSchema: "dbo");
            MoveTable(name: "public.personal_competences", newSchema: "dbo");
            MoveTable(name: "public.vacancies", newSchema: "dbo");
            MoveTable(name: "public.education_levels", newSchema: "dbo");
            MoveTable(name: "public.experience_levels", newSchema: "dbo");
            MoveTable(name: "public.job_types", newSchema: "dbo");
            MoveTable(name: "public.positions", newSchema: "dbo");
            MoveTable(name: "public.position_resumes", newSchema: "dbo");
            MoveTable(name: "public.student_profiles", newSchema: "dbo");
            MoveTable(name: "public.knowleges", newSchema: "dbo");
            MoveTable(name: "public.knowleges_categories", newSchema: "dbo");
            MoveTable(name: "public.searches", newSchema: "dbo");
            MoveTable(name: "public.skills", newSchema: "dbo");
            MoveTable(name: "public.skills_categories", newSchema: "dbo");
        }
        
        public override void Down()
        {
            MoveTable(name: "dbo.skills_categories", newSchema: "public");
            MoveTable(name: "dbo.skills", newSchema: "public");
            MoveTable(name: "dbo.searches", newSchema: "public");
            MoveTable(name: "dbo.knowleges_categories", newSchema: "public");
            MoveTable(name: "dbo.knowleges", newSchema: "public");
            MoveTable(name: "dbo.student_profiles", newSchema: "public");
            MoveTable(name: "dbo.position_resumes", newSchema: "public");
            MoveTable(name: "dbo.positions", newSchema: "public");
            MoveTable(name: "dbo.job_types", newSchema: "public");
            MoveTable(name: "dbo.experience_levels", newSchema: "public");
            MoveTable(name: "dbo.education_levels", newSchema: "public");
            MoveTable(name: "dbo.vacancies", newSchema: "public");
            MoveTable(name: "dbo.personal_competences", newSchema: "public");
            MoveTable(name: "dbo.vacancies_personal_competences", newSchema: "public");
            MoveTable(name: "dbo.personal_competences_levels", newSchema: "public");
            MoveTable(name: "dbo.students_personal_competences", newSchema: "public");
            MoveTable(name: "dbo.personal_competences_approves", newSchema: "public");
            MoveTable(name: "dbo.tutors", newSchema: "public");
            MoveTable(name: "dbo.proffessional_competences_approves", newSchema: "public");
            MoveTable(name: "dbo.students_proffessional_competences", newSchema: "public");
            MoveTable(name: "dbo.proffessional_competences_levels", newSchema: "public");
            MoveTable(name: "dbo.vacancies_proffessional_competences", newSchema: "public");
            MoveTable(name: "dbo.proffessional_competences", newSchema: "public");
            MoveTable(name: "dbo.domain", newSchema: "public");
            MoveTable(name: "dbo.disciplines", newSchema: "public");
            MoveTable(name: "dbo.companies", newSchema: "public");
            MoveTable(name: "dbo.abilities", newSchema: "public");
        }
    }
}
