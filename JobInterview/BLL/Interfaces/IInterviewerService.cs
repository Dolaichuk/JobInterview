using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IInterviewerService
    {
        IEnumerable<InterviewerDTO> GetAllJobInterviews();
        InterviewerDTO GetJobInterview(int id);
        InterviewerDTO CreateJobInterview(InterviewerDTO entity);
        InterviewerDTO UpdateJobInterview(InterviewerDTO entity);
        void DeleteJobInterview(int id);
    }
}
