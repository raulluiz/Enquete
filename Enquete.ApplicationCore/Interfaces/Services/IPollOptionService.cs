using Enquete.ApplicationCore.Entities;
using Enquete.ApplicationCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enquete.ApplicationCore.Interfaces.Services
{
    public interface IPollOptionService : IBaseService<PollOption>
    {
        void SavePollOption(int pollId, int optionId);
        List<OptionVM> GetOptionsByPoll(int pollId);
        List<OptionStatsVM> GetOptionsByPollStats(int pollId);
    }
}
