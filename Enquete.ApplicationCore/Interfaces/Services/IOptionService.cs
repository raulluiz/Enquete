using Enquete.ApplicationCore.Entities;
using Enquete.ApplicationCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enquete.ApplicationCore.Interfaces.Services
{
    public interface IOptionService : IBaseService<Option>
    {
        int SaveOption(OptionVM option);
        void Vote(OptionVoteVM optionVote);
        List<OptionStatsVM> GetOptionStats(int pollId);
    }
}
