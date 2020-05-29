using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class JobInterviewDTO
    {
        public int Id { get; set; }
        public int? CandidateId { get; set; }
        public CandidateDTO Candidate { get; set; }
        public int? VacancyId { get; set; }
        public VacancyDTO Vacancy { get; set; }
        public int? InterviewerId { get; set; }
        public InterviewerDTO Interviewer { get; set; }
        public string StartTimeOfInterview { get; set; }
    }
}
