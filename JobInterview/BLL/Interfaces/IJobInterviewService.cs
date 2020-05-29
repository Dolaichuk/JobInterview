using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IJobInterviewService
    {
        IEnumerable<JobInterviewDTO> GetAllJobInterviews();
        JobInterviewDTO GetJobInterview(int id);
        JobInterviewDTO CreateJobInterview(JobInterviewDTO entity);
        JobInterviewDTO UpdateJobInterview(JobInterviewDTO entity);
        void DeleteJobInterview(int id);
    }
}
