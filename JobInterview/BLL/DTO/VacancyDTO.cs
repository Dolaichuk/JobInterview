using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class VacancyDTO
    {
        public int Id { get; set; }
        public string VacancyName { get; set; }
        public ICollection<JobInterviewDTO> JobInterviews { get; set; }

        public VacancyDTO()
        {
            JobInterviews = new List<JobInterviewDTO>();
        }
    }
}
