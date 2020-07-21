using Enquete.ApplicationCore.Entities;
using Enquete.ApplicationCore.Interfaces.Repository;
using Enquete.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enquete.ApplicationCore.Services
{
    public class OptionService : BaseService<Option>, IOptionService
    {
        private readonly IOptionRepository  _optionRepository;
        public OptionService(IOptionRepository optionRepository)
            : base(optionRepository)
        {
            _optionRepository = optionRepository;
        }

    }
}
