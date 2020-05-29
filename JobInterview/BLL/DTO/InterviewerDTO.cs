using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class InterviewerDTO
    {
        public int Id { get; set; }
        public string InterviewerFirstName { get; set; }
        public string InterviewerLastName { get; set; }
        public ICollection<JobInterviewDTO> JobInterviews { get; set; }

        public InterviewerDTO()
        {
            JobInterviews = new List<JobInterviewDTO>();
        }
    }
}
