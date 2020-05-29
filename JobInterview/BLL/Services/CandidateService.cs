using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CandidateService : ICandidateService
    {
        private readonly IUnitOfWork context;
        private IMapper mapper = Mapper.Instance;

        public CandidateService()
        {
        }
        public CandidateService(IUnitOfWork _context)
        {
            context = _context;
        }

        public CandidateDTO CreateCandidate(CandidateDTO candidateDTO)
        {
            if (candidateDTO == null)
                throw new ArgumentNullException("Candidate is null");

            var candidate = mapper.Map<Candidate>(candidateDTO);

            candidate.Id = candidateDTO.Id;

            context.CandidateRepository.Create(candidate);
            context.Save();

            return candidateDTO;
        }

        public CandidateDTO UpdateCandidate(CandidateDTO candidateDTO)
        {
            if (candidateDTO == null)
                throw new ArgumentNullException("Candidate is null");

            var jobInterview = context.JobInterviewRepository.Get(candidateDTO.Id);

            if (jobInterview == null)
                throw new ArgumentNullException("Candidate is not found");

            jobInterview.Id = candidateDTO.Id;

            context.JobInterviewRepository.Update(jobInterview);
            context.Save();

            return candidateDTO;
        }

        public void DeleteCandidate(int id)
        {
            var jobInterview = context.CandidateRepository.Get(id);

            if (jobInterview == null)
                throw new ArgumentNullException("Candidate is not found");

            context.CandidateRepository.Delete(id);
            context.Save();
        }

        public CandidateDTO GetCandidate(int id)
        {
            return mapper.Map<CandidateDTO>(context.CandidateRepository.Get(id));
        }

        public IEnumerable<CandidateDTO> GetAllCandidates()
        {
            return mapper.Map<IEnumerable<CandidateDTO>>(context.CandidateRepository.GetAll());
        }
    }
}
