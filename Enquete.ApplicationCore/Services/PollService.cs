using Enquete.ApplicationCore.Entities;
using Enquete.ApplicationCore.Interfaces.Repository;
using Enquete.ApplicationCore.Interfaces.Services;
using Enquete.ApplicationCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enquete.ApplicationCore.Services
{
    public class PollService : BaseService<Poll>, IPollService
    {
        private readonly IPollRepository _pollRepository;
        private readonly IOptionService _optionService;
        private readonly IPollOptionService _pollOptionService;
        public PollService(IPollRepository pollRepository, IOptionService optionService, IPollOptionService pollOptionService)
            : base(pollRepository)
        {
            _pollRepository = pollRepository;
            _optionService = optionService;
            _pollOptionService = pollOptionService;
        }

        public int SavePoll(PollOptionsJsonVM pollOptions)
        {
            var poll = _pollRepository.Add(new Poll(pollOptions.Poll_description, 0));

            foreach (var item in pollOptions.options)
            {
                var optionId = _optionService.SaveOption(new OptionVM(item));
                _pollOptionService.SavePollOption(poll.PollId, optionId);
            }

            return poll.PollId;
        }

        public void UpdateViews(int pollId)
        {
            var poll = _pollRepository.GetById(pollId);
            poll.UpdateViews();
            _pollRepository.Update(poll);

        }

    }
}
