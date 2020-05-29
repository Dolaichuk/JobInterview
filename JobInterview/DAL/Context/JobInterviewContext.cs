namespace DAL.Context
{
    using DAL.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class JobInterviewContext : DbContext
    {
        static JobInterviewContext()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<JobInterviewContext>());
        }
        public JobInterviewContext()
            : base("name=JobInterviewContext")
        {
        }

        public virtual DbSet<JobInterview> JobInterviews { get; set; }
        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<Interviewer> Interviewers { get; set; }
        public virtual DbSet<Vacancy> Vacancies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Candidate>().Property(p => p.CandidateFirstName)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Candidate>().Property(p => p.CandidateLastName)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Candidate>().Property(p => p.PhoneNumber)
                .IsRequired()
                .HasMaxLength(15);
            modelBuilder.Entity<Candidate>().Property(p => p.CandidateEmailAddress)
                .IsOptional()
                .IsMaxLength();
        }
    }
}