using Enquete.ApplicationCore.Entities;
using Enquete.ApplicationCore.Interfaces.Repository;
using Enquete.ApplicationCore.Interfaces.Services;
using Enquete.ApplicationCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enquete.ApplicationCore.Services
{
    public class PollOptionService : BaseService<PollOption>, IPollOptionService
    {
        private readonly IPollOptionRepository _pollOptionRepository;
        public PollOptionService(IPollOptionRepository pollOptionRepository)
            : base(pollOptionRepository)
        {
            _pollOptionRepository = pollOptionRepository;
        }

        public void SavePollOption(int pollId, int optionId)
        {
            _pollOptionRepository.Add(new PollOption(pollId, optionId));
        }

        public List<OptionVM> GetOptionsByPoll(int pollId)
        {
            var options = _pollOptionRepository.GetOptionsByPoll(pollId);

            return options;
        }

        public List<OptionStatsVM> GetOptionsByPollStats(int pollId)
        {
            var options = _pollOptionRepository.GetOptionsByPollStats(pollId);

            return options;
        }

    }
}
