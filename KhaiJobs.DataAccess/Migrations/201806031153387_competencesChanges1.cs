namespace KhaiJobs.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class competencesChanges1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.proffessional_competences", "students_proffessional_competences_id", "dbo.students_proffessional_competences");
            DropIndex("dbo.proffessional_competences", new[] { "students_proffessional_competences_id" });
            AddColumn("dbo.students_proffessional_competences", "proffessional_competence_id", c => c.Int());
            CreateIndex("dbo.students_proffessional_competences", "proffessional_competence_id");
            AddForeignKey("dbo.students_proffessional_competences", "proffessional_competence_id", "dbo.proffessional_competences", "id");
            DropColumn("dbo.proffessional_competences", "students_proffessional_competences_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.proffessional_competences", "students_proffessional_competences_id", c => c.Int());
            DropForeignKey("dbo.students_proffessional_competences", "proffessional_competence_id", "dbo.proffessional_competences");
            DropIndex("dbo.students_proffessional_competences", new[] { "proffessional_competence_id" });
            DropColumn("dbo.students_proffessional_competences", "proffessional_competence_id");
            CreateIndex("dbo.proffessional_competences", "students_proffessional_competences_id");
            AddForeignKey("dbo.proffessional_competences", "students_proffessional_competences_id", "dbo.students_proffessional_competences", "id");
        }
    }
}
