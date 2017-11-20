namespace KhaiJobs.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
        }
        
        public override void Down()
        {
            DropForeignKey("public.skills", "id_skills_categories", "public.skills_categories");
            DropForeignKey("public.knowleges", "id_knowleges_categories", "public.knowleges_categories");
            DropForeignKey("public.proffessional_competences", "id_domain", "public.domain");
            DropForeignKey("public.vacancies_proffessional_competences", "id_proffessional_competences", "public.proffessional_competences");
            DropForeignKey("public.vacancies_proffessional_competences", "id_proffessional_competences_levels", "public.proffessional_competences_levels");
            DropForeignKey("public.students_proffessional_competences", "id_proffessional_competences_levels", "public.proffessional_competences_levels");
            DropForeignKey("public.proffessional_competences_approves", "id_students_proffessional_competences", "public.students_proffessional_competences");
            DropForeignKey("public.proffessional_competences_approves", "id_tutors", "public.tutors");
            DropForeignKey("public.personal_competences_approves", "id_tutors", "public.tutors");
            DropForeignKey("public.vacancies_personal_competences", "id_personal_competences_levels", "public.personal_competences_levels");
            DropForeignKey("public.vacancies_proffessional_competences", "id_vacancies", "public.vacancies");
            DropForeignKey("public.vacancies_personal_competences", "id_vacancies", "public.vacancies");
            DropForeignKey("public.vacancies", "id_positions", "public.positions");
            DropForeignKey("public.position_resumes", "id_positions", "public.positions");
            DropForeignKey("public.students_proffessional_competences", "id_student_profiles", "public.student_profiles");
            DropForeignKey("public.students_personal_competences", "id_student_profiles", "public.student_profiles");
            DropForeignKey("public.position_resumes", "id_student_profiles", "public.student_profiles");
            DropForeignKey("public.vacancies_personal_competences", "id_personal_competences", "public.personal_competences");
            DropForeignKey("public.students_personal_competences", "id_personal_competences_levels", "public.personal_competences_levels");
            DropForeignKey("public.personal_competences_approves", "id_students_personal_competences", "public.students_personal_competences");
            DropIndex("public.skills", new[] { "id_skills_categories" });
            DropIndex("public.knowleges", new[] { "id_knowleges_categories" });
            DropIndex("public.position_resumes", new[] { "id_student_profiles" });
            DropIndex("public.position_resumes", new[] { "id_positions" });
            DropIndex("public.vacancies", new[] { "id_positions" });
            DropIndex("public.vacancies_personal_competences", new[] { "id_personal_competences_levels" });
            DropIndex("public.vacancies_personal_competences", new[] { "id_personal_competences" });
            DropIndex("public.vacancies_personal_competences", new[] { "id_vacancies" });
            DropIndex("public.students_personal_competences", new[] { "id_personal_competences_levels" });
            DropIndex("public.students_personal_competences", new[] { "id_student_profiles" });
            DropIndex("public.personal_competences_approves", new[] { "id_students_personal_competences" });
            DropIndex("public.personal_competences_approves", new[] { "id_tutors" });
            DropIndex("public.proffessional_competences_approves", new[] { "id_students_proffessional_competences" });
            DropIndex("public.proffessional_competences_approves", new[] { "id_tutors" });
            DropIndex("public.students_proffessional_competences", new[] { "id_proffessional_competences_levels" });
            DropIndex("public.students_proffessional_competences", new[] { "id_student_profiles" });
            DropIndex("public.vacancies_proffessional_competences", new[] { "id_proffessional_competences_levels" });
            DropIndex("public.vacancies_proffessional_competences", new[] { "id_proffessional_competences" });
            DropIndex("public.vacancies_proffessional_competences", new[] { "id_vacancies" });
            DropIndex("public.proffessional_competences", new[] { "id_domain" });
            DropTable("public.skills_categories");
            DropTable("public.skills");
            DropTable("public.searches");
            DropTable("public.knowleges_categories");
            DropTable("public.knowleges");
            DropTable("public.job_types");
            DropTable("public.experience_levels");
            DropTable("public.education_levels");
            DropTable("public.student_profiles");
            DropTable("public.position_resumes");
            DropTable("public.positions");
            DropTable("public.vacancies");
            DropTable("public.personal_competences");
            DropTable("public.vacancies_personal_competences");
            DropTable("public.personal_competences_levels");
            DropTable("public.students_personal_competences");
            DropTable("public.personal_competences_approves");
            DropTable("public.tutors");
            DropTable("public.proffessional_competences_approves");
            DropTable("public.students_proffessional_competences");
            DropTable("public.proffessional_competences_levels");
            DropTable("public.vacancies_proffessional_competences");
            DropTable("public.proffessional_competences");
            DropTable("public.domain");
            DropTable("public.disciplines");
            DropTable("public.companies");
            DropTable("public.abilities");
        }
    }
}
