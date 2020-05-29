namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Candidates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CandidateFirstName = c.String(nullable: false, maxLength: 50),
                        CandidateLastName = c.String(nullable: false, maxLength: 50),
                        PhoneNumber = c.String(nullable: false, maxLength: 15),
                        CandidateEmailAddress = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.JobInterviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CandidateId = c.Int(),
                        VacancyId = c.Int(),
                        InterviewerId = c.Int(),
                        StartTimeOfInterview = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidates", t => t.CandidateId)
                .ForeignKey("dbo.Interviewers", t => t.InterviewerId)
                .ForeignKey("dbo.Vacancies", t => t.VacancyId)
                .Index(t => t.CandidateId)
                .Index(t => t.VacancyId)
                .Index(t => t.InterviewerId);
            
            CreateTable(
                "dbo.Interviewers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InterviewerFirstName = c.String(nullable: false, maxLength: 50),
                        InterviewerLastName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vacancies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VacancyName = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.JobInterviews", "VacancyId", "dbo.Vacancies");
            DropForeignKey("dbo.JobInterviews", "InterviewerId", "dbo.Interviewers");
            DropForeignKey("dbo.JobInterviews", "CandidateId", "dbo.Candidates");
            DropIndex("dbo.JobInterviews", new[] { "InterviewerId" });
            DropIndex("dbo.JobInterviews", new[] { "VacancyId" });
            DropIndex("dbo.JobInterviews", new[] { "CandidateId" });
            DropTable("dbo.Vacancies");
            DropTable("dbo.Interviewers");
            DropTable("dbo.JobInterviews");
            DropTable("dbo.Candidates");
        }
    }
}
