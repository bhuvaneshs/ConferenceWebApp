using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shared.Models;

namespace SensipleConference.Services
{
    public interface IProposalService
    {
        Task Add(ProposalModel model);
        Task<ProposalModel> Approve(int proposalId);
        Task<IEnumerable<ProposalModel>> GetAll(int conferenceId);
    }
}
