namespace KhaiJobs.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class competencesChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.abilities", "proffessional_competences_id", c => c.Int());
            AddColumn("dbo.proffessional_competences", "students_proffessional_competences_id", c => c.Int());
            AddColumn("dbo.knowleges", "proffessional_competences_id", c => c.Int());
            AddColumn("dbo.skills", "proffessional_competences_id", c => c.Int());
            CreateIndex("dbo.abilities", "proffessional_competences_id");
            CreateIndex("dbo.proffessional_competences", "students_proffessional_competences_id");
            CreateIndex("dbo.knowleges", "proffessional_competences_id");
            CreateIndex("dbo.skills", "proffessional_competences_id");
            AddForeignKey("dbo.abilities", "proffessional_competences_id", "dbo.proffessional_competences", "id");
            AddForeignKey("dbo.knowleges", "proffessional_competences_id", "dbo.proffessional_competences", "id");
            AddForeignKey("dbo.skills", "proffessional_competences_id", "dbo.proffessional_competences", "id");
            AddForeignKey("dbo.proffessional_competences", "students_proffessional_competences_id", "dbo.students_proffessional_competences", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.proffessional_competences", "students_proffessional_competences_id", "dbo.students_proffessional_competences");
            DropForeignKey("dbo.skills", "proffessional_competences_id", "dbo.proffessional_competences");
            DropForeignKey("dbo.knowleges", "proffessional_competences_id", "dbo.proffessional_competences");
            DropForeignKey("dbo.abilities", "proffessional_competences_id", "dbo.proffessional_competences");
            DropIndex("dbo.skills", new[] { "proffessional_competences_id" });
            DropIndex("dbo.knowleges", new[] { "proffessional_competences_id" });
            DropIndex("dbo.proffessional_competences", new[] { "students_proffessional_competences_id" });
            DropIndex("dbo.abilities", new[] { "proffessional_competences_id" });
            DropColumn("dbo.skills", "proffessional_competences_id");
            DropColumn("dbo.knowleges", "proffessional_competences_id");
            DropColumn("dbo.proffessional_competences", "students_proffessional_competences_id");
            DropColumn("dbo.abilities", "proffessional_competences_id");
        }
    }
}
