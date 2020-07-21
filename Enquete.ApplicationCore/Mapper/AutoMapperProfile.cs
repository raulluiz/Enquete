using System;
using System.Collections.Generic;
using System.Text;
using Enquete.ApplicationCore.Entities;
using Enquete.ApplicationCore.ViewModels;

namespace Enquete.ApplicationCore.Mapper
{
    public class AutoMapperProfile : AutoMapper.Profile
    {
        public AutoMapperProfile()
        {
            #region Entidades
            CreateMap<Poll, PollVM>();
            CreateMap<PollVM, Poll>();

            CreateMap<Option, OptionVM>();
            CreateMap<OptionVM, Option>();

            CreateMap<PollOption, PollOptionVM>();
            CreateMap<PollOptionVM, PollOption>();

            #endregion
        }


    }
}
