using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class CandidateDTO
    {
        public int Id { get; set; }
        public string CandidateFirstName { get; set; }
        public string CandidateLastName { get; set; }
        public string PhoneNumber { get; set; }
        public string CandidateEmailAddress { get; set; }
        public ICollection<JobInterviewDTO> JobInterviews { get; set; }

        public CandidateDTO()
        {
            JobInterviews = new List<JobInterviewDTO>();
        }
    }
}
