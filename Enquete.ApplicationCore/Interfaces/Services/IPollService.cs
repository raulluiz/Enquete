using Enquete.ApplicationCore.Entities;
using Enquete.ApplicationCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enquete.ApplicationCore.Interfaces.Services
{
    public interface IPollService : IBaseService<Poll>
    {
        int SavePoll(PollOptionsJsonVM pollOptions);
        void UpdateViews(int pollId);
    }
}
