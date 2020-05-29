using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class JobInterview
    {
        public int Id { get; set; }
        public int? CandidateId { get; set; }
        public Candidate Candidate { get; set; }
        public int? VacancyId { get; set; }
        public Vacancy Vacancy { get; set; }
        public int? InterviewerId { get; set; }
        public Interviewer Interviewer { get; set; }
        public string StartTimeOfInterview { get; set; }
    }
}
