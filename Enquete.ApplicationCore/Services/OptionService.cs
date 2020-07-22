using AutoMapper;
using Enquete.ApplicationCore.Entities;
using Enquete.ApplicationCore.Interfaces.Repository;
using Enquete.ApplicationCore.Interfaces.Services;
using Enquete.ApplicationCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enquete.ApplicationCore.Services
{
    public class OptionService : BaseService<Option>, IOptionService
    {
        private readonly IOptionRepository  _optionRepository;
        private readonly IPollOptionService _pollOptionService;
        private readonly IMapper _mapper;
        public OptionService(IOptionRepository optionRepository, IMapper mapper, IPollOptionService pollOptionService)
            : base(optionRepository)
        {
            _optionRepository = optionRepository;
            _mapper = mapper;
            _pollOptionService = pollOptionService;
        }

        public int SaveOption(OptionVM option)
        {
            var optionVM = _mapper.Map<OptionVM>(_optionRepository.Add(new Option(option.OptionDescription)));

            return optionVM.OptionId;
        }

        public void Vote(OptionVoteVM optionVote)
        {
            var option = _optionRepository.GetById(optionVote.Option_id);
            option.Vote();
            _optionRepository.Update(option);
        }

        public List<OptionStatsVM> GetOptionStats(int pollId)
        {
            var listOptions = _pollOptionService.GetOptionsByPollStats(pollId);
            return listOptions;
        }

    }
}
