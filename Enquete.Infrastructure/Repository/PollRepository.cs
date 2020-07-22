using Enquete.ApplicationCore.Entities;
using Enquete.ApplicationCore.Interfaces.Repository;
using Enquete.ApplicationCore.ViewModels;
using Enquete.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AutoMapper;

namespace Enquete.Infrastructure.Repository
{
    public class PollRepository : BaseRepository<Poll>, IPollRepository
    {
        public PollRepository(EnqueteContext dbContext) : base(dbContext)
        {
        }
    }
}
