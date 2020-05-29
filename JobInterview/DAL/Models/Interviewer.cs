using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Interviewer
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string InterviewerFirstName { get; set; }
        [Required, MaxLength(50)]
        public string InterviewerLastName { get; set; }
        public ICollection<JobInterview> JobInterviews { get; set; }

        public Interviewer()
        {
            JobInterviews = new List<JobInterview>();
        }
    }
}
