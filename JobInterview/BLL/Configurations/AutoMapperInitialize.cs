using AutoMapper;
using BLL.DTO;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Configurations
{
    public class AutoMapperInitialize : Profile
    {
        public AutoMapperInitialize()
        {
            CreateMap<JobInterviewDTO, JobInterview>().ReverseMap();
                //.ForMember(x => x.CandidateFirstName, opt => opt.MapFrom(y => y.Candidates.Select(c => c.CandidateFirstName)))
                //.ForMember(x => x.CandidateLastName, opt => opt.MapFrom(y => y.Candidates.Select(c => c.CandidateLastName)));

            CreateMap<CandidateDTO, Candidate>().ReverseMap();
            CreateMap<VacancyDTO, Vacancy>().ReverseMap();
            CreateMap<InterviewerDTO, Interviewer>().ReverseMap();
        }
        public static void Initialize()
        {
            Mapper.Initialize(cnf => cnf.AddProfile<AutoMapperInitialize>());
        }
    }
}
