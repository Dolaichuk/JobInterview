using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Vacancy
    {
        public int Id { get; set; }
        [Required, MaxLength(20)]
        public string VacancyName { get; set; }
        public ICollection<JobInterview> JobInterviews { get; set; }

        public Vacancy()
        {
            JobInterviews = new List<JobInterview>();
        }
    }
}
