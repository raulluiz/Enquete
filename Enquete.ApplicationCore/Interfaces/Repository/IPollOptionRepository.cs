using Enquete.ApplicationCore.Entities;
using Enquete.ApplicationCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enquete.ApplicationCore.Interfaces.Repository
{
    public interface IPollOptionRepository : IBaseRepository<PollOption>
    {
        List<OptionVM> GetOptionsByPoll(int pollId);
        List<OptionStatsVM> GetOptionsByPollStats(int pollId);
    }
}
