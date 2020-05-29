using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<JobInterview> JobInterviewRepository { get; }
        IGenericRepository<Candidate> CandidateRepository { get; }
        IGenericRepository<Vacancy> VacancyRepository { get; }
        IGenericRepository<Interviewer> InterviewerRepository { get; }
        void Save();
        Task SaveAsync();
    }
}
