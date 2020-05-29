using DAL.Context;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositoties
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly JobInterviewContext context;
        private GenericRepository<JobInterview> jobInterviewRepository;
        private GenericRepository<Candidate> candiadateRepository;
        private GenericRepository<Interviewer> interviewerRepository;
        private GenericRepository<Vacancy> vacancyRepository;

        public UnitOfWork(JobInterviewContext _context)
        {
            context = _context;
        }

        public IGenericRepository<JobInterview> JobInterviewRepository
        {
            get
            {
                if (jobInterviewRepository == null)
                    return new GenericRepository<JobInterview>(context);
                else
                    return jobInterviewRepository;
            }
        }

        public IGenericRepository<Candidate> CandidateRepository
        {
            get
            {
                if (candiadateRepository == null)
                    return new GenericRepository<Candidate>(context);
                else
                    return candiadateRepository;
            }
        }

        public IGenericRepository<Interviewer> InterviewerRepository
        {
            get
            {
                if (interviewerRepository == null)
                    return new GenericRepository<Interviewer>(context);
                else
                    return interviewerRepository;
            }
        }

        public IGenericRepository<Vacancy> VacancyRepository
        {
            get
            {
                if (vacancyRepository == null)
                    return new GenericRepository<Vacancy>(context);
                else
                    return vacancyRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }

        private bool disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
