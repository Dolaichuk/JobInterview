using BLL.Configurations;
using BLL.DTO;
using BLL.Interfaces;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoMapperInitialize.Initialize();

            var vacancy = new VacancyDTO {VacancyName = "HR-Manager" };
            var interviewer = new InterviewerDTO {InterviewerFirstName = "Olexandra", InterviewerLastName = "Kvitkova" };
            var candidate = new CandidateDTO {CandidateFirstName = "Sofia", CandidateLastName = "Stuzuk", PhoneNumber = "+380635596356" } ;
            var jobInterview = new JobInterviewDTO {Candidate = candidate, Vacancy = vacancy, Interviewer = interviewer } ;

            IJobInterviewService jobInterviewService = new JobInterviewService();
            CandidateService candidateService = new CandidateService();
            candidateService.CreateCandidate(candidate);
            jobInterviewService.CreateJobInterview(jobInterview);

            var getAll = jobInterviewService.GetAllJobInterviews();

            //var result = getAll.Select(x => new JobInterviewDTO
            //{
            //    Id = x.Id,
            //    //Vacancy = x.Vacancy,
            //    StartTimeOfInterview = DateTime.Now.ToString(),
            //    CandidateFirstName = x.Candidates.Select(y => y.CandidateFirstName).FirstOrDefault(),
            //    CandidateLastName = x.Candidates.Select(y => y.CandidateLastName).FirstOrDefault()

            //});

            foreach (var item in getAll)
                Console.WriteLine("{0}. {1} {2} \nVacancy: {3} \nInterviewer: {4} {5}", item.Id, item.Candidate.CandidateFirstName, 
                    item.Candidate.CandidateLastName, item.Vacancy.VacancyName, item.Interviewer.InterviewerFirstName, item.Interviewer.InterviewerLastName);

            Console.ReadKey();
        }
    }
}
