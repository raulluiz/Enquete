using Enquete.ApplicationCore.Entities;
using Enquete.ApplicationCore.Interfaces.Repository;
using Enquete.ApplicationCore.ViewModels;
using Enquete.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Enquete.Infrastructure.Repository
{
    public class PollOptionRepository : BaseRepository<PollOption>, IPollOptionRepository
    {
        public PollOptionRepository(EnqueteContext dbContext) : base(dbContext)
        {
        }

        public List<OptionVM> GetOptionsByPoll(int pollId)
        {
            var options = (from pollOption in DbSet
                           join option in Db.Set<Option>() on pollOption.OptionId equals option.OptionId
                           where pollOption.PollId == pollId
                           select new OptionVM(option.OptionId,option.OptionDescription)).ToList();
            return options;
        }

        public List<OptionStatsVM> GetOptionsByPollStats(int pollId)
        {
            var options = (from pollOption in DbSet
                           join option in Db.Set<Option>() on pollOption.OptionId equals option.OptionId
                           where pollOption.PollId == pollId
                           select new OptionStatsVM(option.OptionId, option.Qty)).ToList();
            return options;
        }
    }
}
