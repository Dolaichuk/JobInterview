using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Context;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class JobInterviewService : IJobInterviewService
    {
        private readonly IUnitOfWork context;
        private IMapper mapper = Mapper.Instance;

        public JobInterviewService(IUnitOfWork _context)
        {
            context = _context;
        }
        public JobInterviewService()
        {
        }

        public JobInterviewDTO CreateJobInterview(JobInterviewDTO interviewDTO)
        {
            if (interviewDTO == null)
                throw new ArgumentNullException("JobInterview is null");

            var jobInterview = mapper.Map<JobInterview>(interviewDTO);

            jobInterview.Id = interviewDTO.Id;

            context.JobInterviewRepository.Create(jobInterview);
            context.Save();

            return interviewDTO;
        }

        public async Task<JobInterviewDTO> CreateJobInterviewAsync(JobInterviewDTO entity)
        {
            if (entity == null)
                throw new ArgumentNullException();
            var jobInterview = mapper.Map<JobInterview>(entity);

            context.JobInterviewRepository.Create(jobInterview);
            await context.SaveAsync();

            return entity;

        }

        public JobInterviewDTO UpdateJobInterview(JobInterviewDTO interviewDTO)
        {
            if (interviewDTO == null)
                throw new ArgumentNullException("JobInterview is null");

            var jobInterview = context.JobInterviewRepository.Get(interviewDTO.Id);

            if (jobInterview == null)
                throw new ArgumentNullException("JobInterview is not found");

            jobInterview.Id = interviewDTO.Id;

            context.JobInterviewRepository.Update(jobInterview);
            context.Save();

            return interviewDTO;
        }

        public async Task  UpdateJobInterviewAsync(JobInterviewDTO interviewDTO)
        {
            if (interviewDTO == null)
                throw new ArgumentNullException("JobInterview is null");

            var jobInterview = await context.JobInterviewRepository.GetAsync(interviewDTO.Id);

            if (jobInterview == null)
                throw new ArgumentNullException("JobInterview is not found");

            jobInterview.Id = interviewDTO.Id;

            await context.JobInterviewRepository.UpdateAsync(jobInterview);
            await context.SaveAsync();
        }

        public void DeleteJobInterview(int id)
        {
            var jobInterview = context.JobInterviewRepository.Get(id);

            if (jobInterview == null)
                throw new ArgumentNullException("JobInterview is not found");

            context.JobInterviewRepository.Delete(id);
            context.Save();
        }

        public async Task DeleteJobInterviewAsync(int id)
        {
            var jobInterview = context.JobInterviewRepository.GetAsync(id);

            if(jobInterview == null)
                throw new ArgumentNullException("JobInterview is not found");

            await context.JobInterviewRepository.DeleteAsync(id);
            await context.SaveAsync();
        }

        public JobInterviewDTO GetJobInterview(int id)
        {
            return mapper.Map<JobInterviewDTO>(context.JobInterviewRepository.Get(id));
        }

        public async Task <IEnumerable<JobInterviewDTO>> GetJobInterviewAsync(int id)
        {
            return mapper.Map<IEnumerable<JobInterviewDTO>>(await context.JobInterviewRepository.GetAsync(id));
        }

        public IEnumerable<JobInterviewDTO> GetAllJobInterviews()
        {
            return mapper.Map<IEnumerable<JobInterviewDTO>>(context.JobInterviewRepository.GetAll());
        }

        public async Task<IEnumerable<JobInterviewDTO>> GetAllJobInterviewsAsync()
        {
            return mapper.Map<IEnumerable<JobInterviewDTO>>(await context.JobInterviewRepository.GetAllAsync());
        }
    }
}
