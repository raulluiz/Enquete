using Enquete.ApplicationCore.Entities;
using Enquete.ApplicationCore.Interfaces.Repository;
using Enquete.ApplicationCore.ViewModels;
using Enquete.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Enquete.Infrastructure.Repository
{
    public class OptionRepository : BaseRepository<Option>, IOptionRepository
    {
        public OptionRepository(EnqueteContext dbContext) : base(dbContext)
        {
        }
    }
}
