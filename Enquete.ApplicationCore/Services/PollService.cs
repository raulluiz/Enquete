using Enquete.ApplicationCore.Entities;
using Enquete.ApplicationCore.Interfaces.Repository;
using Enquete.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enquete.ApplicationCore.Services
{
    public class PollService : BaseService<Poll>, IPollService
    {
        private readonly IPollRepository _pollRepository;
        public PollService(IPollRepository pollRepository)
            : base(pollRepository)
        {
            _pollRepository = pollRepository;
        }

    }
}
