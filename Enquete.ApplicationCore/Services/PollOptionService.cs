using Enquete.ApplicationCore.Entities;
using Enquete.ApplicationCore.Interfaces.Repository;
using Enquete.ApplicationCore.Interfaces.Services;
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

    }
}
