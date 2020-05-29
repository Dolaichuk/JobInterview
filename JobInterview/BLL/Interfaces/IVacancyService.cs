using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IVacancyService
    {
        IEnumerable<VacancyDTO> GetAllJobInterviews();
        VacancyDTO GetJobInterview(int id);
        VacancyDTO CreateJobInterview(VacancyDTO entity);
        VacancyDTO UpdateJobInterview(VacancyDTO entity);
        void DeleteJobInterview(int id);
    }
}
