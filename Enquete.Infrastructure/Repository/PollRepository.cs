using Enquete.ApplicationCore.Entities;
using Enquete.ApplicationCore.Interfaces.Repository;
using Enquete.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enquete.Infrastructure.Repository
{
    public class PollRepository : BaseRepository<Poll>, IPollRepository
    {
        public PollRepository(EnqueteContext dbContext) : base(dbContext)
        {
        }
    }
}
