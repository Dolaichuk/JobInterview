using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ICandidateService
    {
        IEnumerable<CandidateDTO> GetAllCandidates();
        CandidateDTO GetCandidate(int id);
        CandidateDTO CreateCandidate(CandidateDTO entity);
        CandidateDTO UpdateCandidate(CandidateDTO entity);
        void DeleteCandidate(int id);
    }
}
