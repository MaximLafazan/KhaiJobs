namespace KhaiJobs.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class competencesChanges2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.students_personal_competences", "personal_competence_id", c => c.Int());
            CreateIndex("dbo.students_personal_competences", "personal_competence_id");
            AddForeignKey("dbo.students_personal_competences", "personal_competence_id", "dbo.personal_competences", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.students_personal_competences", "personal_competence_id", "dbo.personal_competences");
            DropIndex("dbo.students_personal_competences", new[] { "personal_competence_id" });
            DropColumn("dbo.students_personal_competences", "personal_competence_id");
        }
    }
}
