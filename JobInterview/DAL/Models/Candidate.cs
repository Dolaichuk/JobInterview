using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public string CandidateFirstName { get; set; }
        public string CandidateLastName { get; set; }
        public string PhoneNumber { get; set; }
        public string CandidateEmailAddress { get; set; }
        public ICollection<JobInterview> JobInterviews { get; set; }
        
        public Candidate()
        {
            JobInterviews = new List<JobInterview>();
        }
    }
}
